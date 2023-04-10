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

        void ReStart()
        {
            j = 0;
            //清空原本的符號
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            //使按鈕可按
            btn1.Enabled = true;
            btn2.Enabled = true;   
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

        }

        
        void Step(System.Windows.Forms.Button name)
        {
            //點擊按鈕後該按鈕會呈現圈或差
            j++;
            if( j % 2 ==0 )
            {
                name.Text = "O";
                name.Enabled = false;
                //要讓按鈕被鎖定不能更改
            }
            else
            {
                name.Text = "X";
                name.Enabled = false;
                //要讓按鈕鎖定不能更改
            }

            

            //當局數>=6，開始進行勝負的判斷，判斷為或橫或直或斜的按鈕為同一個符號，增加效率，就不用每次跑這麼大坨
            if (j >= 5)
            { 
                bool victory = (
                //橫的三行同符號
                (btn1.Text == btn2.Text & btn1.Text == btn3.Text & btn3.Text == btn2.Text & btn1.Text != "" & btn2.Text != "" & btn3.Text!="") |
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
                        MessageBox.Show(name.Text + "手獲勝!");
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

        private void btn1_Click(object sender, EventArgs e) //改寫看看，看能不能用一個event解決
        {
            
            Step(btn2);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Step(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Step(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Step(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Step(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Step(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Step(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Step(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Step(btn9);
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
