using System.Drawing;
using System.Windows.Forms;

namespace RGB_CMYK
{
    public partial class CMYK : Form
    {
        public CMYK((Bitmap c, Bitmap m, Bitmap y, Bitmap k) bmps)
        {
            InitializeComponent();

            cPictureBox.Image = bmps.c;
            mPictureBox.Image = bmps.m;
            yPictureBox.Image = bmps.y;
            kPictureBox.Image = bmps.k;
        }
    }
}
