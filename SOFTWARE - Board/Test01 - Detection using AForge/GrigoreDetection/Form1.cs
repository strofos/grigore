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
        public string DirPath;
        public string OriginalBoardImage = "robo-board1.png";
        public string TemplateBoardImage = "robo-board1.{0}.png";
        
        public Form1()
        {
            InitializeComponent();

            DirPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName
                + "\\Images\\";

        }

        private void ParseImage(int imageId) {

            string difImagePath = string.Format(TemplateBoardImage, imageId);

            Bitmap orig = (Bitmap)Bitmap.FromFile(DirPath + OriginalBoardImage);
            Bitmap dif = (Bitmap)Bitmap.FromFile(DirPath + difImagePath);

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
            ParseImage(1);
        }

        private void buttonParseImage2_Click(object sender, EventArgs e)
        {
            ParseImage(2);
        }

        private void buttonParseImage3_Click(object sender, EventArgs e)
        {
            ParseImage(3);
        }

    }
}
