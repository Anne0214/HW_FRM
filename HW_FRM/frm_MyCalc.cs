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
    public partial class frm_MyCalc : Form
    {
        public frm_MyCalc()
        {
            InitializeComponent();
        }
        public enum type
        {
            plus,
            minus,
            mutiply,
            divide

        };

        public void Calc(int t) 
        {//進行計算的方法，使用需要輸入現在是用加減乘除哪一種
            try
            {
                double Num1, Num2;
                bool a = double.TryParse(txtNum1.Text, out Num1);
                bool b = double.TryParse(txtNum2.Text, out Num2);
                if (a == false || b == false)
                {
                    MessageBox.Show("請輸入數值");
                }
                else
                {
                    switch (t)
                    { //使用enum就可以每種狀況寫數字就好，少打字
                        case 0:
                            txtAnswer.Text = (Num1 + Num2).ToString();
                            break;
                        case 1:
                            txtAnswer.Text = (Num1 - Num2).ToString();
                            break;
                        case 2:
                            txtAnswer.Text = (Num1 * Num2).ToString();
                            break;
                        case 3:
                            txtAnswer.Text = (Num1 / Num2).ToString();
                            break;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("發生不明錯誤(･8･)請稍後再試");
            }
    }
      
        private void btnPlus_Click(object sender, EventArgs e)
        { //在使用方法時，可以用enum來選擇要哪種計算，比較好識別
            Calc((int)type.plus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Calc((int)type.minus);
        }

        private void btnMutiply(object sender, EventArgs e)
        {
            Calc((int)type.mutiply);
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            Calc((int)type.divide);
        }
    }
}
