using System;
using System.Collections.Generic;
using System.IO;
using GrigoreDetection;
using System.Drawing;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Math.Geometry;
using AForge;

namespace GrigoreDetectionConsole
{
    public class Detection
    {
        private string dirPath;
        public Robot Grigore;
        public System.Drawing.Image internalImageContainer;

        public string OriginalBoardImage = "robo-board1.png";
        public IList<string> DifBoardImages = new List<string> { "robo-board1.1.png", "robo-board1.2.png", "robo-board1.3.png" };
        public string GrigoreImage = "robo-grigore.png";
        
        public Detection() { }

        public void Run() {
            dirPath = Environment.CurrentDirectory + "/Images/";
            if (!Directory.Exists(dirPath))
                dirPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Images/";

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

           
            GeneratedImage();

            ParseImage(-1);

            Console.ReadKey();
        }

        private void ParseImage(int imageId)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine(string.Format("Start parsing {0}", startTime));

            string difImagePath = "";

            if (imageId >= 0) difImagePath = DifBoardImages[imageId];

            Bitmap orig;
            Bitmap dif;

            try
            {
                Console.WriteLine("Load files");

                orig = (Bitmap)Bitmap.FromFile(OriginalBoardImage);

                if (imageId >= 0)
                    dif = (Bitmap)Bitmap.FromFile(difImagePath);
                else
                    dif = (Bitmap)internalImageContainer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERR: " + ex.Message);
                Console.WriteLine(ex.StackTrace);

                // kill any exception due to missing files
                return;
            }    

            Difference filter = new Difference(orig);
            dif = filter.Apply(dif);
            Console.WriteLine("Apply difference filter");

            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(dif);
            Console.WriteLine("Blob counting");
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

                Console.Write(string.Format("Detected {0} points", edgePoints.Count));

                if (edgePoints.Count <= 1)
                    continue;

                List<IntPoint> points = new List<IntPoint>();

                if (shapeChecker.IsQuadrilateral(edgePoints))
                    Console.WriteLine(", quadrilateral");
                else if (shapeChecker.IsConvexPolygon(edgePoints, out points))
                    Console.WriteLine(", convex poligon");
                else if (shapeChecker.IsTriangle(edgePoints, out points))
                    Console.WriteLine(", triangle");

                Pen usePen = shapeChecker.IsQuadrilateral(edgePoints) ? redPen : bluePen;

                int centerX = edgePoints[0].X;
                int centerY = edgePoints[0].Y;

                for (int j = 0; j < edgePoints.Count - 1; j++)
                {
                    centerX += edgePoints[j + 1].X;
                    centerY += edgePoints[j + 1].Y;

                    g.DrawLine(usePen, edgePoints[j].X, edgePoints[j].Y, edgePoints[j + 1].X, edgePoints[j + 1].Y);
                }

                // add last point
                centerX += edgePoints[edgePoints.Count - 1].X;
                centerY += edgePoints[edgePoints.Count - 1].Y;

                g.DrawLine(usePen
                    , edgePoints[0].X, edgePoints[0].Y
                    , edgePoints[edgePoints.Count - 1].X, edgePoints[edgePoints.Count - 1].Y);

                Console.WriteLine(string.Format("Original (x, y): {0}, {1}"
                    , new object[] { 
                        (centerX / edgePoints.Count), (centerY / edgePoints.Count)
                    }));
                Console.WriteLine(string.Format("Detected (x, y): {0}, {1}"
                    , (centerX / edgePoints.Count)
                    , (centerY / edgePoints.Count)
                ));
            }

            redPen.Dispose();
            bluePen.Dispose();
            g.Dispose();

            //DifI = dif;
            dif.Save(dirPath + "processed-dif.jpg");

            Console.WriteLine(string.Format("{1}, {0} sec", (DateTime.Now - startTime), ""));

        }

        private void GeneratedImage()
        {
            Console.WriteLine(string.Format("Start genetaing {0}'", Grigore.Direction));
            Console.WriteLine(string.Format("Position (x, y): {0}, {1}", Grigore.Position.X, Grigore.Position.Y));

            Bitmap orig;

            try
            {
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

            internalImageContainer = orig;

            orig.Save(dirPath + "processed-generated.jpg");
        }
    }
}
