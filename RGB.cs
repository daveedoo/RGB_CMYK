using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RGB_CMYK
{
    public partial class RGB : Form
    {
        private static int K100percent(int R, int G, int B) => 255 - Math.Max(R, Math.Max(G, B));
        private static int K0percent(int R, int G, int B) => 0;

        private Bitmap bmp; // obrazek
        private Func<int, int, int, int> KFunc = K100percent;

        private Point? MouseLeftDown;
        private (int CurveIndex, int PointIndex) MovedPoint = (-1, -1);

        private Bezier curves;


        public RGB()
        {
            InitializeComponent();

            changePicOpenFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Photos"));
            bmp = new Bitmap(Image.FromFile(Path.Combine(changePicOpenFileDialog.InitialDirectory, "Mogielica.jpg")));

            // inicjalizacja krzywych beziera
            curves = new Bezier();

            bezierPictureBox.Image = curves.bezierBitmap;
        }

        /// <summary>
        /// Rozdziela kolor na 4, aplikując również "krzywe szarości" Beziera (zapisane w polach cCurve, ..., kCurve)
        /// </summary>
        /// <param name="color">Kolor, który chcemy rozseparować na CMYK</param>
        /// <param name="getK">Funkcja obliczająca wartość K na podstawie R, G, B koloru</param>
        /// <returns>Kolory reprezentujące składowe cmyk</returns>
        private (Color, Color, Color, Color) getCMYK(Color color, Func<int, int, int, int> getK)
        {
            int r = color.R;
            int g = color.G;
            int b = color.B;

            int k = getK(r, g, b);

            Color C = Color.FromArgb(r + k, 255, 255);
            C = Color.FromArgb(
                255 - curves.Curves[0].Values[255 - C.R],
                C.G,
                C.B);
            Color M = Color.FromArgb(255, g + k, 255);
            M = Color.FromArgb(
                M.R,
                255 - curves.Curves[1].Values[255 - M.G],
                M.B);
            Color Y = Color.FromArgb(255, 255, b + k);
            Y = Color.FromArgb(
                Y.R,
                Y.G,
                255 - curves.Curves[2].Values[255 - Y.B]);

            Color K = Color.FromArgb(255 - k, 255 - k, 255 - k);
            K = Color.FromArgb(
                curves.Curves[3].Values[K.R],
                curves.Curves[3].Values[K.G],
                curves.Curves[3].Values[K.B]);

            return (C, M, Y, K);
        }

        private (Bitmap, Bitmap, Bitmap, Bitmap) separateAndAddCurves(Bitmap bitmap)
        {
            Bitmap C = new Bitmap(bitmap.Width, bitmap.Height);
            Bitmap M = new Bitmap(bitmap.Width, bitmap.Height);
            Bitmap Y = new Bitmap(bitmap.Width, bitmap.Height);
            Bitmap K = new Bitmap(bitmap.Width, bitmap.Height);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    (Color c, Color m, Color y, Color k) sep = getCMYK(pixel, KFunc);

                    C.SetPixel(x, y, sep.c);
                    M.SetPixel(x, y, sep.m);
                    Y.SetPixel(x, y, sep.y);
                    K.SetPixel(x, y, sep.k);
                }
            }
            return (C, M, Y, K);
        }

        private void showSeparatedButton_Click(object sender, EventArgs e)
        {
            CMYK cmyk = new CMYK(separateAndAddCurves(bmp));
            cmyk.Show(this);
        }

        private void changePicButton_Click(object sender, EventArgs e)
        {
            if (changePicOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(Image.FromFile(changePicOpenFileDialog.FileName));
                pictureBox.Image = new Bitmap(bmp);
            }
        }

        private void k0RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (k0RadioButton.Checked)
                KFunc = K0percent;
        }

        private void k100RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (k100RadioButton.Checked)
                KFunc = K100percent;
        }

        private void bezierPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MovedPoint = curves.IsCloseToPoint(e.Location);
                if (MovedPoint != (-1, -1))
                    MouseLeftDown = e.Location;
            }
        }

        private void bezierPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseLeftDown.HasValue)
            {
                curves.MovePoint(MovedPoint.CurveIndex, MovedPoint.PointIndex,
                    e.X - MouseLeftDown.Value.X,
                    e.Y - MouseLeftDown.Value.Y);
                bezierPictureBox.Image = curves.bezierBitmap;
                MouseLeftDown = e.Location;
            }
        }

        private void bezierPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseLeftDown = null;
                MovedPoint = (-1, -1);
            }
        }

        private void clearKButton_Click(object sender, EventArgs e)
        {
            curves.StraightCurve(3);
            bezierPictureBox.Image = curves.bezierBitmap;

        }

        private void kCurveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (kCurveRadioButton.Checked)
            {
                curves.Curves[0].Active = false;
                curves.Curves[1].Active = false;
                curves.Curves[2].Active = false;
                curves.Curves[3].Active = true;
                curves.Redraw();
                bezierPictureBox.Image = curves.bezierBitmap;

            }
        }

        private void Cyan_CheckedChanged(object sender, EventArgs e)
        {
            if (Cyan.Checked)
            {
                curves.Curves[0].Active = true;
                curves.Curves[1].Active = false;
                curves.Curves[2].Active = false;
                curves.Curves[3].Active = false;
                curves.Redraw();
                bezierPictureBox.Image = curves.bezierBitmap;

            }
        }

        private void Magenta_CheckedChanged(object sender, EventArgs e)
        {
            if (Magenta.Checked)
            {
                curves.Curves[0].Active = false;
                curves.Curves[1].Active = true;
                curves.Curves[2].Active = false;
                curves.Curves[3].Active = false;
                curves.Redraw();
                bezierPictureBox.Image = curves.bezierBitmap;

            }
        }

        private void Yellow_CheckedChanged(object sender, EventArgs e)
        {
            if (Yellow.Checked)
            {
                curves.Curves[0].Active = false;
                curves.Curves[1].Active = false;
                curves.Curves[2].Active = true;
                curves.Curves[3].Active = false;
                curves.Redraw();
                bezierPictureBox.Image = curves.bezierBitmap;

            }
        }

        private void clearCButton_Click(object sender, EventArgs e)
        {
            curves.StraightCurve(0);
            bezierPictureBox.Image = curves.bezierBitmap;

        }

        private void clearMButton_Click(object sender, EventArgs e)
        {
            curves.StraightCurve(1);
            bezierPictureBox.Image = curves.bezierBitmap;

        }

        private void clearYButton_Click(object sender, EventArgs e)
        {
            curves.StraightCurve(2);
            bezierPictureBox.Image = curves.bezierBitmap;

        }
    }
}
