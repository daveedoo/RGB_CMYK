using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_CMYK
{
    public partial class CMYK : Form
    {
        private Bitmap C, M, Y, K;

        public CMYK(Bitmap c, Bitmap m, Bitmap y)
        {
            InitializeComponent();

            cPictureBox.Image = c;
            mPictureBox.Image = m;
            yPictureBox.Image = y;
        }
    }
}
