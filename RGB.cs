using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_CMYK
{
    public partial class RGB : Form
    {
        private Bitmap bmp;

        public RGB()
        {
            InitializeComponent();

            changePicOpenFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Photos"));
            bmp = new Bitmap(Image.FromFile(Path.Combine(changePicOpenFileDialog.InitialDirectory, "Mogielica.jpg")));
        }

        private void changePicButton_Click(object sender, EventArgs e)
        {
            if (changePicOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(Image.FromFile(changePicOpenFileDialog.FileName));
                pictureBox.Image = new Bitmap(bmp);
            }
        }

        private void showSeparatedButton_Click(object sender, EventArgs e)
        {
            //Bitmap C = separate(bmp, separateC);
            //Bitmap M = separate(bmp, separateM);
            //Bitmap Y = separate(bmp, separateY);
            //Bitmap K;


            CMYK cmyk = new CMYK(separate(bmp));
            cmyk.Show(this);
        }

        private (Color, Color, Color, Color) getCMYK(Color color)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            double k = 1.0 - Math.Max(r, Math.Max(g, b));
            double c = 1 - r - k;
            double m = 1 - g - k;
            double y = 1 - b - k;

            Color C = Color.FromArgb(Convert.ToInt32(255*(1.0 - c)), 255, 255);
            Color M = Color.FromArgb(255, Convert.ToInt32(255*(1.0 - m)), 255);
            Color Y = Color.FromArgb(255, 255, Convert.ToInt32(255*(1.0 - y)));
            Color K = Color.FromArgb(
                Convert.ToInt32(255 * (1.0 - k)),
                Convert.ToInt32(255 * (1.0 - k)),
                Convert.ToInt32(255 * (1.0 - k)));
            return (C, M, Y, K);
        }

        //private Color separateC(Color color)
        //{
        //    double p = 1.0 - color.R / 255.0;
        //    return Color.FromArgb(
        //                Convert.ToInt32(Color.Cyan.R * p),
        //                Convert.ToInt32(Color.Cyan.G * p),
        //                Convert.ToInt32(Color.Cyan.B * p));
        //}
        //private Color separateM(Color color, double K)
        //{
        //    double p = (1.0 - color.G / 255.0 - K) / (1.0 - K);
        //    return Color.FromArgb(
        //        Convert.ToInt32(Color.Magenta.R * p),
        //        Convert.ToInt32(Color.Magenta.G * p),
        //        Convert.ToInt32(Color.Magenta.B * p));
        //}
        //private Color separateY(Color color)
        //{
        //    double p = 1.0 - color.B / 255.0;
        //    return Color.FromArgb(
        //        Convert.ToInt32(Color.Yellow.R * p),
        //        Convert.ToInt32(Color.Yellow.G * p),
        //        Convert.ToInt32(Color.Yellow.B * p));
        //}

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
                    (Color c, Color m, Color y, Color k) sep = getCMYK(pixel);

                    C.SetPixel(x, y, sep.c);
                    M.SetPixel(x, y, sep.m);
                    Y.SetPixel(x, y, sep.y);
                    K.SetPixel(x, y, sep.k);
                }
            }
            return (C, M, Y, K);
        }
    }
}
