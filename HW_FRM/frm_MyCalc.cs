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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool a=double.TryParse(txtNum1.Text,out Num1);
            bool b= double.TryParse(txtNum2.Text, out Num2);
            if (a==false | b==false )
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                double answer = Num1 + Num2;
                txtAnswer.Text =answer.ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool a = double.TryParse(txtNum1.Text, out Num1);
            bool b = double.TryParse(txtNum2.Text, out Num2);
            if (a == false | b == false)
            {
                MessageBox.Show("請輸入數值");
            }else
            {
                double answer = Num1 - Num2;
                txtAnswer.Text = answer.ToString();
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool a = double.TryParse(txtNum1.Text, out Num1);
            bool b = double.TryParse(txtNum2.Text, out Num2);
            if (a == false | b == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                double answer = Num1 * Num2;
                txtAnswer.Text = answer.ToString();
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool a = double.TryParse(txtNum1.Text, out Num1);
            bool b = double.TryParse(txtNum2.Text, out Num2);
            if (a == false | b == false)
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                double answer = Num1 / Num2;
                txtAnswer.Text = answer.ToString();
            }
        }
    }
}
