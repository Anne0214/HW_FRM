using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_FRM
{
    public partial class frm_PictureViewer2 : Form
    {
        public frm_PictureViewer2()
        {
            InitializeComponent();
        }
        public frm_PictureViewer2(System.Drawing.Bitmap picture)
        {
            InitializeComponent();
            this.pictureBox1.Image =picture;
        }
    }
}
