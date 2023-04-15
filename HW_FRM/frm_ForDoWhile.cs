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
    public partial class frm_ForDoWhile : Form
    {
        public frm_ForDoWhile()
        {
            InitializeComponent();
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {

            labResult.Text = "樂透號碼" + "\n";
            Random rd = new Random();
            for(int i = 0; i < 6; i++) {
                int j = rd.Next(1, 49);
                labResult.Text += " ";
                labResult.Text += j.ToString();
                    };
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int number = 100; //要進行二進位的數字
            int remainder; //餘數
            string result = ""; //二進位的結果

            while (number > 0)
            {
                remainder = number % 2; //除以2剩餘的餘數不是1就是0，記下這次除二的餘數
                number /= 2; //把該數除二
                result = remainder.ToString()+result; //把這次的餘數放入前幾次餘數的紀錄
            }
            labResult.Text = result;

        }

        private void btnXmas_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            int row;
            bool a  =int.TryParse(txtRow.Text,out row);

            if (a == false)
            {
                MessageBox.Show("請輸入整數");
            }
            else
            {
                for (int i = 1; i <= row; i++)
                {
                    string line = "\n" + string.Concat(Enumerable.Repeat("*", i)); //不能直接用乘的，難受

                    labResult.Text += line;

                }
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            labResult.Text = "九九乘法表";

            for(int i = 1; i < 10; i++)
            {
                string line = "";
                labResult.Text += "\n";
                for (int g = 2; g < 10; g++)
                {
                    string result = (i * g).ToString("00");


                    string j = $" {g}× {i} = {result} |";
                    line += j;




                }
                labResult.Text += line;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int from,to,step;
            bool a = int.TryParse(txtFrom.Text, out from);
            bool b = int.TryParse(txtTo.Text, out to);
            bool c = int.TryParse(txtStep.Text,out step);
            int sum = 0;

            if (a==false| b==false| c==false)
            {
                MessageBox.Show("請輸入正整數");
            }
            else if (step == 0)
            {

                MessageBox.Show("Step不可為0");
            }
            else
            {
                for (int i = from; i <= to; i += step)
                {
                    sum += i;
                }

                labResult.Text = from + "到 " + to + " 相隔為" + (step - 1)
                + "\n加總為" + sum;
            }
          
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int from, to, step;
            bool a = int.TryParse(txtFrom.Text, out from);
            bool b = int.TryParse(txtTo.Text, out to);
            bool c = int.TryParse(txtStep.Text, out step);
            int sum = 0;

            if (a == false | b == false | c == false)
            {
                MessageBox.Show("請輸入正整數");
            }
            else if (step == 0)
            {

                MessageBox.Show("Step不可輸入0");
            }
         
            else
            {
                int i = from;
                while (i <= to)
                {
                    sum += i;
                    i += step;
                }

                labResult.Text = from + "到 " + to + " 相隔為" + (step - 1)
                + "\n加總為" + sum;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            //要用do-while，會確保執行至少一次，且在尾部檢查條件
            int from, to, step;
            bool a = int.TryParse(txtFrom.Text, out from);
            bool b = int.TryParse(txtTo.Text, out to);
            bool c = int.TryParse(txtStep.Text, out step);
            int sum = 0;

            if (a == false | b == false | c == false)
            {
                MessageBox.Show("請輸入正整數");
            }
            else if (step==0){

                MessageBox.Show("Step不可輸入0");
            }else
            {//因為do-while會先執行一次，所以要先建立第一步的檢查，不把檢查寫在do裡面是因為從第二步起每次執行都會有判斷的重工，降低效率
                int i = from;
                if (i + step >= to)
                {
                    sum = i;
                }
                else
                {
                    do
                    {
                        sum += i;
                        i += step;


                    } while (i <= to);
                }
                

                labResult.Text = from + "到 " + to + " 相隔為" + (step - 1)
                + "\n加總為" + sum;
            }
        }
    }
}
