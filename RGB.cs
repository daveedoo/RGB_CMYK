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
            Bitmap C = separate(bmp, separateC);
            Bitmap M = separate(bmp, separateM);
            Bitmap Y = separate(bmp, separateY);
            CMYK cmyk = new CMYK(C, M, Y);
            cmyk.Show(this);
        }

        private Color separateC(Color color)
        {
            double p = 1.0 - color.R / 255.0;
            return Color.FromArgb(
                        Convert.ToInt32(Color.Cyan.R * p),
                        Convert.ToInt32(Color.Cyan.G * p),
                        Convert.ToInt32(Color.Cyan.B * p));
        }
        private Color separateM(Color color)
        {
            double p = 1.0 - color.G / 255.0;
            return Color.FromArgb(
                Convert.ToInt32(Color.Magenta.R * p),
                Convert.ToInt32(Color.Magenta.G * p),
                Convert.ToInt32(Color.Magenta.B * p));
        }
        private Color separateY(Color color)
        {
            double p = 1.0 - color.B / 255.0;
            return Color.FromArgb(
                Convert.ToInt32(Color.Yellow.R * p),
                Convert.ToInt32(Color.Yellow.G * p),
                Convert.ToInt32(Color.Yellow.B * p));
        }

        private Bitmap separate(Bitmap bitmap, Func<Color, Color> func)
        {
            Bitmap bmp = new Bitmap(bitmap.Width, bitmap.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    bmp.SetPixel(x, y, func(pixel));
                }
            }
            return bmp;
        }
    }
}
