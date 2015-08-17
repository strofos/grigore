using System;
using System.Drawing;

namespace GrigoreDetection
{
    public class Robot
    {
        public Robot(Size s) {
            Boundaries = s;

            Random rnd = new Random();

            Position = new Point(rnd.Next(s.Width), rnd.Next(s.Height));

            Direction = 180 - rnd.Next(360);
        }

        public Size Boundaries { get; set; }
        public Point Position { get; set; }
        public int Direction { get; private set; }
        public Bitmap Image { get; set; }

        public void Forward(int steps) {
            Position = new Point(
                Position.X + (int)(steps * Math.Cos((Math.PI / 180) * Direction))
            ,   Position.Y - (int)(steps * Math.Sin((Math.PI / 180) * Direction))
            );
        }

        public void Reverse(int steps) {
            Forward(-steps);
        }

        public void TurnLeft(int degrees) {
            Direction += degrees;

            if (Direction > 180) {
                Direction -= 360;
            }
            else if (Direction < -180) {
                Direction += 360;
            }
        }

        public void TurnRight(int degrees) {
            TurnLeft(-degrees);
        }
    }
}
