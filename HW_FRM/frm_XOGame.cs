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
    public partial class frm_XOGame : Form
    {
        public frm_XOGame()
        {
            InitializeComponent();
        }
        int j = 0; //用來紀錄現在下到第幾個，判斷是O還是X

        void ReStart() //遊戲開始/重開用的方法
        {
            j = 0;
            foreach (System.Windows.Forms.Button b in flowLayoutPanel1.Controls)
            {
                //清空原本的符號
                b.Text = "";

                //使按鈕可按
                b.Enabled = true;
            }

        }

        
        void Step(System.Windows.Forms.Button button)
        {
            try
            { //點擊按鈕後1.按鈕變圈或叉 2. 按鈕鎖定不可再按
                j++;
                button.Text = (j % 2 == 0) ? "O" : "X";
                button.Enabled = false;



                //當局數>=6，開始進行勝負的判斷，判斷為或橫或直或斜的按鈕為同一個符號，增加效率，就不用每次跑這麼大坨
                if (j >= 5)
                {
                    bool victory = (
                    //橫的三行同符號
                    (btn1.Text == btn2.Text & btn1.Text == btn3.Text & btn3.Text == btn2.Text & btn1.Text != "" & btn2.Text != "" & btn3.Text != "") |
                    (btn4.Text == btn5.Text & btn4.Text == btn6.Text & btn5.Text == btn6.Text & btn4.Text != "" & btn5.Text != "" & btn6.Text != "") |
                    (btn7.Text == btn8.Text & btn7.Text == btn9.Text & btn8.Text == btn9.Text & btn7.Text != "" & btn8.Text != "" & btn9.Text != "") |
                    //直的三行同符號
                    (btn1.Text == btn4.Text & btn1.Text == btn7.Text & btn4.Text == btn7.Text & btn1.Text != "" & btn4.Text != "" & btn7.Text != "") |
                    (btn2.Text == btn5.Text & btn2.Text == btn8.Text & btn8.Text == btn5.Text & btn2.Text != "" & btn5.Text != "" & btn8.Text != "") |
                    (btn3.Text == btn6.Text & btn3.Text == btn9.Text & btn6.Text == btn9.Text & btn3.Text != "" & btn6.Text != "" & btn9.Text != "") |
                    //斜的兩行同符號
                    (btn1.Text == btn5.Text & btn1.Text == btn9.Text & btn5.Text == btn9.Text & btn1.Text != "" & btn5.Text != "" & btn9.Text != "") |
                    (btn3.Text == btn5.Text & btn3.Text == btn7.Text & btn5.Text == btn7.Text & btn3.Text != "" & btn5.Text != "" & btn7.Text != ""));
                    switch (victory)
                    {
                        case true:
                            MessageBox.Show(button.Text + "手獲勝!");
                            ReStart();
                            break;
                        case false://當無人獲勝時，判斷是否全場的按鈕都有符號，有則跳彈窗顯示平手
                            if (btn1.Text != "" & btn2.Text != "" & btn3.Text != "" & btn4.Text != "" & btn5.Text != "" & btn6.Text != "" & btn7.Text != "" & btn8.Text != "" & btn9.Text != "")
                            {
                                MessageBox.Show("平手! 按下確定重新開始");
                                ReStart();
                            }


                            break;

                    }

                }

            }
            catch (Exception) { 
                MessageBox.Show("發生不明錯誤> < 遊戲即將重開");
                ReStart();
            }
           

        }

        private void btn_Click(object sender, EventArgs e) //改寫看看，看能不能用一個event解決
        {
            
            Step((System.Windows.Forms.Button)sender);
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            ReStart();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
