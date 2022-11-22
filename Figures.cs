using System.Drawing;
using System;

namespace FigureFormation
{
    public class Figures
    {
        public Bitmap CurrentBitmap { get; set; }
        public Color CurrentColor { get; }

        public Figures(Bitmap currentBitmap, Color currentColor)
        {
            CurrentBitmap = currentBitmap;
            CurrentColor = currentColor;
        }

        public void DrawPixel(int x, int y)
        {
            if (x >= 0 && x < CurrentBitmap.Width &&
                y >= 0 && y < CurrentBitmap.Height)
            {
                CurrentBitmap.SetPixel(x, y, CurrentColor);
            }
        }

        private void DrawSymmetricalPixels(int x1, int x2, int y1, int y2)
        {
            DrawPixel(x1 + x2, y1 + y2);
            DrawPixel(x1 + x2, y1 - y2);
            DrawPixel(x1 - x2, y1 + y2);
            DrawPixel(x1 - x2, y1 - y2);
        }

        public void DrawLine(Point point1, Point point2)
        {
            var currentX = point1.X;
            var currentY = point1.Y;

            DrawPixel(currentX, currentY);

            var deltaX = point2.X - currentX;
            var deltaY = point2.Y - currentY;

            var changeX = deltaX > 0 ? 1 : deltaX < 0 ? -1 : 0;
            var changeY = deltaY > 0 ? 1 : deltaY < 0 ? -1 : 0;

            deltaX = Math.Abs(deltaX);
            deltaY = Math.Abs(deltaY);

            var direction = deltaX > deltaY ? deltaX : deltaY;

            var errorX = 0;
            var errorY = 0;

            for (var i = 0; i <= direction; ++i)
            {
                errorX += deltaX;
                errorY += deltaY;

                if (errorX > direction)
                {
                    errorX -= direction;
                    currentX += changeX;
                }

                if (errorY > direction)
                {
                    errorY -= direction;
                    currentY += changeY;
                }

                DrawPixel(currentX, currentY);
            }
        }

        public void DrawCircle(Point center, int radius)
        {
            var x = 0;
            var y = radius;

            var delta = 1 - 2 * radius;

            int error;

            while (y >= x)
            {
                DrawSymmetricalPixels(center.X, x, center.Y, y);
                DrawSymmetricalPixels(center.X, y, center.Y, x);

                error = 2 * (delta + y) - 1;

                if (delta < 0 && error <= 0)
                {
                    delta += 2 * ++x + 1;
                    continue;
                }

                if (delta > 0 && error > 0)
                {
                    delta -= 2 * --y + 1;
                    continue;
                }

                delta += 2 * (++x - --y);
            }
        }

        public void DrawEllipse(Point center, int radiusX, int radiusY)
        {
            var x = 0;
            var y = radiusY;

            var powRadiusX = radiusX * radiusX;
            var powRadiusY = radiusY * radiusY;

            var delta =
                4 * powRadiusY * (x + 1) * (x + 1) +
                powRadiusX * (2 * y - 1) * (2 * y - 1) -
                4 * powRadiusX * powRadiusY;

            while (powRadiusX * (2 * y - 1) > 2 * powRadiusY * (x + 1))
            {
                DrawSymmetricalPixels(center.X, x, center.Y, y);

                delta =
                    delta < 0 ?
                    delta + 4 * powRadiusY * (2 * ++x + 3) :
                    delta - 8 * powRadiusX * (y-- - 1) + 4 * powRadiusY * (2 * ++x + 3);
            }

            delta =
                powRadiusY * ((2 * x + 1) * (2 * x + 1)) +
                4 * powRadiusX * ((y + 1) * (y + 1)) -
                4 * powRadiusX * powRadiusY;

            while (y + 1 != 0)
            {
                DrawSymmetricalPixels(center.X, x, center.Y, y);

                delta =
                    delta < 0 ?
                    delta + 4 * powRadiusX * (2 * --y + 3) :
                    delta - 8 * powRadiusY * (x++ + 1) + 4 * powRadiusX * (2 * --y + 3);
            }
        }
    }
}
