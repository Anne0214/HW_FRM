using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_hw2
{
    public partial class frm_MyCalc : Form
    {
        public frm_MyCalc()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" | txtNum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                double answer = double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text);
                txtAnswer.Text =answer.ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" | txtNum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                double answer = double.Parse(txtNum1.Text) - double.Parse(txtNum2.Text);
                txtAnswer.Text = answer.ToString();
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" | txtNum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                double answer = double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text);
                txtAnswer.Text = answer.ToString();
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" | txtNum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                double answer = double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text);
                txtAnswer.Text = answer.ToString();
            }
        }
    }
}
