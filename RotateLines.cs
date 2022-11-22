using System;
using System.Drawing;
using System.Threading;

namespace FigureFormation
{
    public class RotateLines
    {
        private MainForm form;
        private Figures figures;
        private Point initPoint;
        private int length1, length2, margin1, margin2, velocity1, velocity2;
        private bool clockwise1, clockwise2;

        public RotateLines(
            MainForm form, 
            Figures figures, 
            Point initPoint, 
            int margin1, 
            int margin2, 
            int length1, 
            int velocity1, 
            bool clockwise1, 
            int length2, 
            int velocity2,
            bool clockwise2) 
        {
            this.form = form;
            this.figures = figures;
            this.initPoint = initPoint;
            this.length1 = length1;
            this.clockwise1 = clockwise1;
            this.margin1 = margin1;
            this.velocity1 = velocity1;
            this.length2 = length2;
            this.clockwise2 = clockwise2;
            this.margin2 = margin2;
            this.velocity2 = velocity2;
        }
        public void Run()
        {
            var i = 0.0D;
            var j = 0.0D;

            var speed1Dx = 0.05 + velocity1 / 100 * 5;
            var speed2Dx = 0.15 + (velocity2 / 10);

            while (true)
            {
                figures.CurrentBitmap = new Bitmap(figures.CurrentBitmap.Width, figures.CurrentBitmap.Height);

                figures.DrawLine(initPoint, RotatePoint(initPoint, length1, i, clockwise1));

                var point2 = RotatePoint(initPoint, length1 - margin1, i, clockwise1);

                figures.DrawLine(
                    RotatePoint(point2, length2 / 2 - margin2, j + Math.PI, clockwise2), 
                    RotatePoint(point2, length2 / 2 + margin2, j, clockwise2));

                i += speed1Dx; 
                j += speed2Dx;

                form.SetBitmap(figures.CurrentBitmap);

                Thread.Sleep(25);
            }
        }
        public Point RotatePoint(Point center, int radius, double t, bool flag)
        {
            var point = new Point();

            var x = (int)(radius * Math.Cos(t));

            if (!flag) x *= -1;

            point.X = center.X + x;
            point.Y = center.Y + (int)(radius * Math.Sin(t));

            return point;
        }
    }
}
