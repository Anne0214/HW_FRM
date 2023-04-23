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



        private void pictureBox_Click(object sender, EventArgs e)
        { //每個圖片的點擊事件
            //由frm_PictureViewer2來作為放大的視窗
            frm_PictureViewer2 frm2 = new frm_PictureViewer2((System.Drawing.Bitmap)((System.Windows.Forms.PictureBox)sender).Image); 
            frm2.Show();
        }

        
    }
}
