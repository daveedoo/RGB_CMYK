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
        Image img;

        public RGB()
        {
            InitializeComponent();

            changePicOpenFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Photos"));
        }

        private void changePicButton_Click(object sender, EventArgs e)
        {
            if (changePicOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(changePicOpenFileDialog.FileName);
                pictureBox.Image = new Bitmap(img);
            }
        }
    }
}
