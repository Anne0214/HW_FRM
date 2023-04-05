using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace frm_hw2
{
    public partial class frm_ScreenSaver : Form
    {
        int stepX = 5, stepY = 5;
        public frm_ScreenSaver()
        {
            InitializeComponent();
            
        }
        //decimal xStart = System.Windows.Forms.Cursor.Position.X;
        //decimal yStart = System.Windows.Forms.Cursor.Position.Y;


        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((ball.Location.X + ball.Width) > this.ClientSize.Width || ball.Location.X < 0)
            {
                stepX = 0 - stepX;
            }
            if ((ball.Location.Y + ball.Height) > this.ClientSize.Height || ball.Location.Y < 0)
            {
                stepY = 0 - stepY;

                ball.Location = new Point(ball.Location.X + stepX, ball.Location.Y + stepY);

            }
        }

            private void frm_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {

            
            
        }

        private void frm_ScreenSaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
