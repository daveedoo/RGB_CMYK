using System;
using System.Drawing;

namespace RGB_CMYK
{
    class Bezier
    {
        public BezierCurve[] Curves = new BezierCurve[4];   // c, m, y, k - kolejność
        public Bitmap bezierBitmap { get; private set; }

        public Bezier()
        {
            Point P1 = new Point(64, 64);
            Point P2 = new Point(192, 192);
            Curves[0] = new BezierCurve(P1, P2, Color.Cyan, false);
            Curves[1] = new BezierCurve(P1, P2, Color.Magenta, false);
            Curves[2] = new BezierCurve(P1, P2, Color.Yellow, false);
            Curves[3] = new BezierCurve(P1, P2, Color.Black, true);

            bezierBitmap = new Bitmap(510, 510);
            Redraw();
        }

        public void Redraw()
        {
            Bitmap bmp = new Bitmap(bezierBitmap.Width, bezierBitmap.Height);
            Graphics g = Graphics.FromImage(bmp);

            for (int i = 0; i < Curves.Length; i++)
            {
                Curves[i].Draw(ref bmp);
            }

            bezierBitmap = bmp;
        }

        public (int, int) IsCloseToPoint(Point m)
        {
            for (int i = 0; i < Curves.Length; i++)
            {
                if (Curves[i].Active)
                {
                    int index = Curves[i].IsCloseToPoint(m);
                    if (index != -1)
                        return (i, index);
                }
            }
            return (-1, -1);
        }

        public void MovePoint(int curveIndex, int pointIndex, int offsetX, int offsetY)
        {
            if (curveIndex < 0 || curveIndex > 3)
                throw new ArgumentException("Bad index");
            Curves[curveIndex].MovePoint(pointIndex, offsetX, offsetY);
            Redraw();
        }

        public void StraightCurve(int curveIndex)
        {
            Curves[curveIndex] = new BezierCurve(new Point(64, 64), new Point(192, 192), Color.Black, Curves[curveIndex].Active);
            Redraw();
        }

    }
}
