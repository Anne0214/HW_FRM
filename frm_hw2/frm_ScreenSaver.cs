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
        
        public frm_ScreenSaver()
        {
            InitializeComponent();
            
        }
        private Point mouseLocation;

        int StepX = 5, StepY = 5; //設定每一步的移動距離
       

            private void frm_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty) //當此值不為空時才能比較，避免第一次執行時出錯
            {if (Math.Abs(mouseLocation.X - e.X) > 2 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 2) //每次移動前先進行判定，這樣就能確保mouseLocation存的是前一個位置，能跟當前位置做加減變化比較
                { this.Close(); }
                

            }

            mouseLocation = e.Location; //游標位置用mouseLoation紀錄，從這邊取
        }

        private void frm_ScreenSaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ScreenSaver_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e) //指定時間間隔執行程式
        {
            if((ball.Location.X +ball.Width)>this.ClientSize.Width || ball.Location.X < 0){
                //球的左上角點的X座標加上球的寬度(相當於球的右上角)，如果這個座標會超過表單工作區的寬度。或是左上角觸邊。
                StepX = 0 - StepX; //讓step轉換正負，會往反方向移動
            }
            if ((ball.Location.Y + ball.Height) > this.ClientSize.Height || ball.Location.Y < 0)
            { //與上述同理
                StepY = 0 - StepY;
            }
            ball.Location = new Point(ball.Location.X + StepX, ball.Location.Y + StepY); //這會讓球開始移動
        }
    }
}
