using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using AForge.Imaging;
using AForge;
using AForge.Math.Geometry;
using AForge.Imaging.Filters;

namespace GrigoreDetection
{
   
    public partial class Form1 : Form
    {

        public Robot Grigore;

        public string OriginalBoardImage = "robo-board1.png";
        public IList<string> DifBoardImages = new List<string> { "robo-board1.1.png", "robo-board1.2.png", "robo-board1.3.png" };
        public string GrigoreImage = "robo-grigore.png";
        
        public Form1()
        {
            InitializeComponent();

            string dirPath = Environment.CurrentDirectory + "\\Images\\";
            if (!Directory.Exists(dirPath))
                dirPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\";

            openImageDialog.InitialDirectory = Environment.CurrentDirectory;

            OriginalBoardImage = dirPath + OriginalBoardImage;

            for (int idx = 0; idx < DifBoardImages.Count; idx++)
                DifBoardImages[idx] = dirPath + DifBoardImages[idx];

            GrigoreImage = dirPath + GrigoreImage;
            Grigore = new Robot(new Size(640, 400));
            //// set it to origin, unrotated
            //Grigore.Position = new System.Drawing.Point(0, 0);
            //Grigore.TurnLeft(-Grigore.Direction);
            try { Grigore.Image = (Bitmap)Bitmap.FromFile(GrigoreImage); }
            catch { }

            UpdateUI();

            GeneratedImage();
        }

        private void UpdateUI() {
            labelBasePath.Text = OriginalBoardImage;

            if (OriginalBoardImage.Length > 30)
                labelBasePath.Text = "..." + OriginalBoardImage.Substring(OriginalBoardImage.Length - 30);
            else
                labelBasePath.Text = OriginalBoardImage;

            if (DifBoardImages[0].Length > 35)
                labelImagePath1.Text = "..." + DifBoardImages[0].Substring(DifBoardImages[0].Length - 35);
            else
                labelImagePath1.Text = DifBoardImages[0];

            if (DifBoardImages[1].Length > 35)
                labelImagePath2.Text = "..." + DifBoardImages[1].Substring(DifBoardImages[1].Length - 35);
            else
                labelImagePath2.Text = DifBoardImages[1];

            if (DifBoardImages[2].Length > 35)
                labelImagePath3.Text = "..." + DifBoardImages[2].Substring(DifBoardImages[2].Length - 35);
            else
                labelImagePath3.Text = DifBoardImages[2];


            if (GrigoreImage.Length > 30)
                labelRobotImagePath.Text = "..." + GrigoreImage.Substring(GrigoreImage.Length - 30);
            else
                labelRobotImagePath.Text = GrigoreImage;
        }

        private void BrowseImage(int imageId) {
            openImageDialog.ShowDialog();

            if (string.IsNullOrEmpty(openImageDialog.FileName))
                return;

            if (imageId == -1)
                OriginalBoardImage = openImageDialog.FileName;
            else if (imageId == -2)
            {
                GrigoreImage = openImageDialog.FileName;
                try { Grigore.Image = (Bitmap)Bitmap.FromFile(GrigoreImage); }
                catch { }
            }
            else
                DifBoardImages[imageId] = openImageDialog.FileName;

            UpdateUI();

            if (imageId >= 0)
                ParseImage(imageId);
            else if (imageId == -2)
                GeneratedImage();
        }

        private void ParseImage(int imageId)
        {
            DateTime startTime = DateTime.Now;
            labelDetection.Text = "";

            string difImagePath = "";
            
            if(imageId >= 0) difImagePath = DifBoardImages[imageId];

            Bitmap orig;
            Bitmap dif;

            try
            {
                orig = (Bitmap)Bitmap.FromFile(OriginalBoardImage);

                if (imageId >= 0)
                    dif = (Bitmap)Bitmap.FromFile(difImagePath);
                else
                    dif = (Bitmap)pictureBoxGenerated.Image;
            }
            catch {
                // kill any exception due to missing files
                return;
            }

            pictureBoxOrig.Image = dif;

            Difference filter = new Difference(orig);
            dif = filter.Apply(dif);

            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(dif);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // create Graphics object to draw on the image and a pen
            Graphics g = Graphics.FromImage(dif);
            Pen redPen = new Pen(Color.Red, 3);
            Pen bluePen = new Pen(Color.Blue, 1);
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            // check each object and draw circle around objects, which
            // are recognized as circles
            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);

                labelDetection.Text = string.Format("{0} points", edgePoints.Count);

                if (edgePoints.Count <= 1)
                    continue;

                List<IntPoint> points = new List<IntPoint>();

                if (shapeChecker.IsQuadrilateral(edgePoints))
                    labelDetection.Text += ", quadrilateral";
                else if (shapeChecker.IsConvexPolygon(edgePoints, out points))
                    labelDetection.Text += ", convex poligon";
                else if (shapeChecker.IsTriangle(edgePoints, out points))
                    labelDetection.Text += ", triangle";

                Pen usePen = shapeChecker.IsQuadrilateral(edgePoints) ? redPen : bluePen;

                int centerX = edgePoints[0].X;
                int centerY = edgePoints[0].Y;
                int minX = centerX;
                int minY = centerY;
                int maxX = centerX;
                int maxY = centerY;
                for (int j = 0; j < edgePoints.Count - 1; j++)
                {
                    centerX += edgePoints[j + 1].X;
                    centerY += edgePoints[j + 1].Y;

                    if (edgePoints[j + 1].X < minX) minX = edgePoints[j + 1].X;
                    if (edgePoints[j + 1].Y < minY) minY = edgePoints[j + 1].Y;
                    if (edgePoints[j + 1].X > maxX) maxX = edgePoints[j + 1].X;
                    if (edgePoints[j + 1].Y > maxX) maxX = edgePoints[j + 1].Y;

                    g.DrawLine(usePen, edgePoints[j].X, edgePoints[j].Y, edgePoints[j + 1].X, edgePoints[j + 1].Y);
                }

                g.DrawLine(usePen
                    , edgePoints[0].X, edgePoints[0].Y
                    , edgePoints[edgePoints.Count - 1].X, edgePoints[edgePoints.Count - 1].Y);

                labelDetectedPosition.Text = string.Format("{0}, {1}"
                    , new object[] { 
                        (centerX / edgePoints.Count), (centerY / edgePoints.Count)
                        //, maxX - minX, maxY - minY
                    });
                labelDetectionOffset.Text = string.Format("{0}, {1}"
                    , Grigore.Position.X - (centerX / edgePoints.Count)
                    , Grigore.Position.Y - (centerY / edgePoints.Count)
                );
            }

            redPen.Dispose();
            bluePen.Dispose();
            g.Dispose();

            pictureBoxRoboBoard.Image = dif;

            labelDetection.Text = string.Format("{1}, {0} sec", (DateTime.Now - startTime), labelDetection.Text);

        }

        private void GeneratedImage() {
            labelDegree.Text = string.Format("{0}'", Grigore.Direction);
            labelPosition.Text = string.Format("{0}, {1}", Grigore.Position.X, Grigore.Position.Y);
            
            Bitmap orig;

            try { 
                orig = (Bitmap)Bitmap.FromFile(OriginalBoardImage); 
            }
            catch
            {
                // kill any exception due to missing files
                return;
            }

            Bitmap rotatedRobot = AForge.Imaging.Image.Clone(Grigore.Image, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Graphics g = Graphics.FromImage(orig);

            BaseRotateFilter filter = new RotateNearestNeighbor(Grigore.Direction, false);
            filter.FillColor = Color.Transparent;
            rotatedRobot = filter.Apply(rotatedRobot);

            g.DrawImage(rotatedRobot, Grigore.Position);

            g.Dispose();

            pictureBoxGenerated.Image = orig;
        }

        private void buttonParseImage1_Click(object sender, EventArgs e)
        {
            ParseImage(0);
        }

        private void buttonParseImage2_Click(object sender, EventArgs e)
        {
            ParseImage(1);
        }

        private void buttonParseImage3_Click(object sender, EventArgs e)
        {
            ParseImage(2);
        }

        private void buttonBrowseBaseImage_Click(object sender, EventArgs e)
        {
            BrowseImage(-1);
        }

        private void buttonBrowseImage1_Click(object sender, EventArgs e)
        {
            BrowseImage(0);
        }

        private void buttonBrowseImage2_Click(object sender, EventArgs e)
        {
            BrowseImage(1);
        }

        private void buttonBrowseImage3_Click(object sender, EventArgs e)
        {
            BrowseImage(2);
        }
        
        private void buttonBrowseRobotImage_Click(object sender, EventArgs e)
        {
            BrowseImage(-2);
        }

        private void buttonMoveFw_Click(object sender, EventArgs e)
        {
            Grigore.Forward(10);

            GeneratedImage();

            ParseImage(-2);
        }

        private void buttonMoveRv_Click(object sender, EventArgs e)
        {
            Grigore.Reverse(10);

            GeneratedImage();

            ParseImage(-2);
        }

        private void buttonTurnLeft_Click(object sender, EventArgs e)
        {
            Grigore.TurnLeft(30);

            GeneratedImage();

            ParseImage(-2);
        }

        private void buttonTurnRight_Click(object sender, EventArgs e)
        {
            Grigore.TurnRight(30);

            GeneratedImage();

            ParseImage(-2);
        }

    }
}
