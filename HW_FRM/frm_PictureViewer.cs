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
    public partial class frm_PictureViewer : Form
    {
        public frm_PictureViewer()
        {
            InitializeComponent();
        }

        void ShowDetail(System.Windows.Forms.PictureBox box)
        {
            frm_PictureViewer2 frm2 = new frm_PictureViewer2((System.Drawing.Bitmap)box.Image);
            frm2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowDetail(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowDetail(pictureBox2);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowDetail(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowDetail(pictureBox4);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowDetail(pictureBox5);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowDetail(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ShowDetail(pictureBox7);
        }

    }
}
