using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
       
        public string OriginalBoardImage = "robo-board1.png";
        public IList<string> DifBoardImages = new List<string> { "robo-board1.1.png", "robo-board1.2.png", "robo-board1.3.png" };
        
        public Form1()
        {
            InitializeComponent();

            string dirPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName
                + "\\Images\\";

            openImageDialog.InitialDirectory = Environment.CurrentDirectory;

            OriginalBoardImage = dirPath + OriginalBoardImage;

            for (int idx = 0; idx < DifBoardImages.Count; idx++)
                DifBoardImages[idx] = dirPath + DifBoardImages[idx];

            UpdateUI();
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
        }

        private void BrowseImage(int imageId) {
            openImageDialog.ShowDialog();

            if (string.IsNullOrEmpty(openImageDialog.FileName))
                return;

            if (imageId == -1)
                OriginalBoardImage = openImageDialog.FileName;
            else
                DifBoardImages[imageId] = openImageDialog.FileName;

            UpdateUI();

            if (imageId >= 0)
                ParseImage(imageId);
        }

        private void ParseImage(int imageId)
        {
            string difImagePath = DifBoardImages[imageId];

            Bitmap orig;
            Bitmap dif;

            try
            {
                orig = (Bitmap)Bitmap.FromFile(OriginalBoardImage);
                dif = (Bitmap)Bitmap.FromFile(difImagePath);
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

                Pen usePen = shapeChecker.IsQuadrilateral(edgePoints) ? redPen : bluePen;

                for (int j = 0; j < edgePoints.Count - 1; j++)
                    g.DrawLine(usePen, edgePoints[j].X, edgePoints[j].Y, edgePoints[j + 1].X, edgePoints[j + 1].Y);

                g.DrawLine(usePen
                    , edgePoints[0].X, edgePoints[0].Y
                    , edgePoints[edgePoints.Count - 1].X, edgePoints[edgePoints.Count - 1].Y);
            }

            redPen.Dispose();
            bluePen.Dispose();
            g.Dispose();

            pictureBoxRoboBoard.Image = dif;
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

    }
}
