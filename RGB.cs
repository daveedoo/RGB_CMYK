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
        private Bitmap Bezier; // bitmapa z wykresami krzywych Beziera
        private BezierCurve curve;

        private Point? MouseLeftDown;
        private int MovedPointIndex = -1;



        public RGB()
        {
            InitializeComponent();

            changePicOpenFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Photos"));
            bmp = new Bitmap(Image.FromFile(Path.Combine(changePicOpenFileDialog.InitialDirectory, "Mogielica.jpg")));

            bezierPictureBox.Image = Bezier = new Bitmap(bezierPictureBox.ClientRectangle.Width, bezierPictureBox.ClientRectangle.Height);
            if (Bezier.Width != 512 || Bezier.Height != 512)
                throw new Exception("bezzierPictureBox musi mieć wymiary 512x512");

            //Graphics g = Graphics.FromImage(Bezzier);
            //GraphicsContainer containerState = g.BeginContainer();
            //// Flip the Y-Axis
            //g.ScaleTransform(1.0F, -1.0F);
            //// Translate the drawing area accordingly
            //g.TranslateTransform(0.0F, -(float)Height);


            // testing Bezzier()
            Point P0 = new Point(0, 0);
            Point P1 = new Point(64, 64);
            Point P2 = new Point(192, 192);
            Point P3 = new Point(255, 255);
            curve = new BezierCurve(P0, P1, P2, P3);
            bezierPictureBox.Image = curve.Draw();
        }

        private (Color, Color, Color, Color) getCMYK(Color color, Func<int, int, int, int> getK)
        {
            int r = color.R;
            int g = color.G;
            int b = color.B;

            int k = getK(r, g, b);

            Color C = Color.FromArgb(r + k, 255, 255);
            Color M = Color.FromArgb(255, g + k, 255);
            Color Y = Color.FromArgb(255, 255, b + k);
            Color K = Color.FromArgb(
                Convert.ToInt32(255 - k),
                Convert.ToInt32(255 - k),
                Convert.ToInt32(255 - k));
            return (C, M, Y, K);
        }

        private (Bitmap, Bitmap, Bitmap, Bitmap) separate(Bitmap bitmap)
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
            CMYK cmyk = new CMYK(separate(bmp));
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
                MovedPointIndex = curve.IsCloseToPoint(e.Location);
                if (MovedPointIndex != -1)
                    MouseLeftDown = e.Location;
            }
        }

        private void bezierPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseLeftDown.HasValue)
            {
                bezierPictureBox.Image = curve.MovePoint(MovedPointIndex,
                    e.X - MouseLeftDown.Value.X,
                    e.Y - MouseLeftDown.Value.Y);
                MouseLeftDown = e.Location;
            }
        }

        private void bezierPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseLeftDown = null;
                MovedPointIndex = -1;
            }
        }
    }
}
