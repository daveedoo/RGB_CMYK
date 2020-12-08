using System;
using System.Drawing;

namespace RGB_CMYK
{
    class BezierCurve
    {
        public int[] Values;
        //private Point P0, P1, P2, P3;   
        private Point[] Points = new Point[4];  // points used for calculations
        private Point[] drawPoints = new Point[4];  // points used for drawing
        //private Point p0, p1, p2, p3;
        private const int radius = 5;
        //Bitmap bitmap;

        // P1.X < P2.X
        public BezierCurve(Point P0, Point P1, Point P2, Point P3)
        {
            //if (bmp.Width != 512 || bmp.Height != 512)  // dla uproszczenia obliczeń przyjmuję tylko bitmapy 512x512
            //    throw new ArgumentException();

            Points[0] = P0;
            Points[1] = P1;
            Points[2] = P2;
            Points[3] = P3;
            for (int i = 0; i < drawPoints.Length; i++)
                drawPoints[i] = new Point(2 * Points[i].X, 512 - 2 * Points[i].Y);

            //bitmap = bmp;

            CalcValues();
        }

        public Bitmap Draw()
        {
            //if (bmp.Width != 512 || bmp.Height != 512)  // dla uproszczenia obliczeń przyjmuję tylko bitmapy 512x512
            //    throw new ArgumentException();

            // współrzędne punktów przeliczone dla dobrego rysowania na bitmapie
            Bitmap newbmp = new Bitmap(512, 512);
            //bmp.Dispose();

            Graphics g = Graphics.FromImage(newbmp);
            g.DrawBezier(Pens.Red, drawPoints[0], drawPoints[1], drawPoints[2], drawPoints[3]);

            for (int i = 0; i < drawPoints.Length; i++)
                g.DrawEllipse(Pens.Black, drawPoints[i].X - radius, drawPoints[i].Y - radius, 2*radius, 2*radius);

            return newbmp;
        }

        private double distance(Point p1, Point p2) => Math.Sqrt((p2.X - p1.X)*(p2.X - p1.X) + (p2.Y - p1.Y)*(p2.Y - p1.Y));
        public int IsCloseToPoint(Point m)
        {
            for (int i = 0; i < drawPoints.Length; i++)
            {
                if (distance(drawPoints[i], m) < radius)
                    return i; 
            }
            return -1;
        }
        public Bitmap MovePoint(int index, int offsetX, int offsetY)
        {
            if (index < 0 || index > Points.Length - 1)
                throw new ArgumentException("Bad index");

            drawPoints[index].Offset(offsetX, offsetY);
            Points[index].Offset(offsetX/2, offsetY/2);

            return Draw();
        }

        private static Func<double, double> crt = x => (x < 0 ? -Math.Pow(-x, 1f / 3f) : Math.Pow(x, 1f / 3f));  // cube root
        // https://stackoverflow.com/questions/51879836/cubic-bezier-curves-get-y-for-given-x-special-case-where-x-of-control-points
        // Find the roots for a cubic polynomial with bernstein coefficients
        // {pa, pb, pc, pd}. The function will first convert those to the
        // standard polynomial coefficients, and then run through Cardano's
        // formula for finding the roots of a depressed cubic curve.
        private double[] findRoots(double x, double pa, double pb, double pc, double pd)
        {
            double
              pa3 = 3 * pa,
              pb3 = 3 * pb,
              pc3 = 3 * pc,
              a = -pa + pb3 - pc3 + pd,
              b = pa3 - 2 * pb3 + pc3,
              c = -pa3 + pb3,
              d = pa - x;
            double q;
            // Fun fact: any Bezier curve may (accidentally or on purpose)
            // perfectly model any lower order curve, so we want to test 
            // for that: lower order curves are much easier to root-find.
            if (Math.Abs(a) < 0.000001)
            {
                // this is not a cubic curve.
                if (Math.Abs(b) < 0.000001)
                {
                    // in fact, this is not a quadratic curve either.
                    if (Math.Abs(c) < 0.000001)
                    {
                        // in fact in fact, there are no solutions.
                        return new double[] { };
                    }
                    // linear solution:
                    return new double[] { -d / c };
                }
                // quadratic solution:
                q = Math.Sqrt(c * c - 4 * b * d);
                double b2 = 2 * b;
                return new double[]{
                  (q - c) / b2,
                  (-c - q) / b2
                };
            }

            // At this point, we know we need a cubic solution,
            // and the above a/b/c/d values were technically
            // a pre-optimized set because a might be zero and
            // that would cause the following divisions to error.
            b /= a;
            c /= a;
            d /= a;

            q = (2 * b * b * b - 9 * b * c + 27 * d) / 27;
            double
              b3 = b / 3,
              p = (3 * c - b * b) / 3,
              p3 = p / 3,
              q2 = q / 2,
              discriminant = q2 * q2 + p3 * p3 * p3,
              u1, v1;

            // case 1: three real roots, but finding them involves complex
            // maths. Since we don't have a complex data type, we use trig
            // instead, because complex numbers have nice geometric properties.
            if (discriminant < 0)
            {
                double mp3 = -p / 3;
                double r = Math.Sqrt(mp3 * mp3 * mp3);
                double t = -q / (2 * r);
                double cosphi = t < -1 ? -1 : t > 1 ? 1 : t;
                double phi = Math.Acos(cosphi);
                double crtr = crt(r);
                double t1 = 2 * crtr;
                return new double[]{
                      t1 * Math.Cos(phi / 3) - b3,
                      t1 * Math.Cos((phi + 2*Math.PI) / 3) - b3,
                      t1 * Math.Cos((phi + 2 * 2*Math.PI) / 3) - b3
                    };
            }

            // case 2: three real roots, but two form a "double root",
            // and so will have the same resultant value. We only need
            // to return two values in this case.
            else if (discriminant == 0)
            {
                u1 = q2 < 0 ? crt(-q2) : -crt(q2);
                return new double[]{
                    2 * u1 - b3,
                    -u1 - b3
                };
            }

            // case 3: one real root, 2 complex roots. We don't care about
            // complex results so we just ignore those and directly compute
            // that single real root.
            else
            {
                double sd = Math.Sqrt(discriminant);
                u1 = crt(-q2 + sd);
                v1 = crt(q2 + sd);
                return new double[] { u1 - v1 - b3 };
            }
        }

        private void CalcValues()
        {
            Point P0 = Points[0];
            Point P1 = Points[1];
            Point P2 = Points[2];
            Point P3 = Points[3];
            // współczyniki funkcji y(t) = B3*t^3 + B2*t^2 + B1*t + B0
            int B0 = P0.Y;
            int B1 = 3 * (P1.Y - P0.Y);
            int B2 = 3 * (P2.Y - 2 * P1.Y + P0.Y);
            int B3 = P3.Y - 3 * P2.Y + 3 * P1.Y - P0.Y;

            Values = new int[256];

            for (int x = 0; x < 256; x++)
            {
                //double[] roots = findRoots(x, P3.X, P2.X, P1.X, P0.X);
                double[] roots = findRoots(x, P0.X, P1.X, P2.X, P3.X);
                double t = 0.0;
                if (roots.Length > 0)
                {
                    foreach (double _t in roots)
                    {
                        if (_t < 0 || _t > 1) continue;
                        t = _t;
                        break;
                    }
                }
                double y = B3*t*t*t + B2*t*t + B1*t + B0;
                Values[x] = Convert.ToInt32(y);
            }
        }

    }
}
