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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();

        }

        public void GetData(out double downPayment,out double rate,out double term, out double loan)
        { //需要取得用戶輸入的資料時用的方法
            downPayment = Convert.ToDouble(txtDownPayment.Text);
            rate = Convert.ToDouble(txtRate.Text);
            rate = rate * 0.01;
            term = Convert.ToDouble(txtTerm.Text);
            loan = Convert.ToDouble(txtLoan.Text);
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            try
            {
                //取得用戶輸入的數值
                double downPayment;
                double rate;
                double term;
                double loan;
                GetData(out downPayment,out rate,out term,out loan);

                //進行計算
                CalcLoan calcLoan = new CalcLoan();

                double PMT = calcLoan.PMT(loan, rate, downPayment, term);
                PMT = Math.Round(PMT);
                MessageBox.Show("月付額:" + PMT + "元");

            }
            catch (FormatException) { MessageBox.Show("請輸入正確格式的數字"); }
            catch  (Exception) { MessageBox.Show("發生不明錯誤>< 暫時無法使用"); }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            { //取得用戶輸入的數值
                double downPayment;
                double rate;
                double term;
                double loan;
                GetData(out downPayment, out rate, out term, out loan);

                //進行計算

                CalcLoan calcLoan = new CalcLoan();
                double result = calcLoan.TotalPay(loan, rate, downPayment, term);
                result = Math.Round(result);
                MessageBox.Show("總付款:" + result + "元");

            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入正確格式的數字");
            }
            catch (Exception)
            {
                MessageBox.Show("發生不明錯誤>< 暫時無法使用");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                //取得用戶輸入的數值
                double downPayment;
                double rate;
                double term;
                double loan;
                GetData(out downPayment, out rate, out term, out loan);


                //進行計算
                CalcLoan calcLoan = new CalcLoan();
                double total = calcLoan.TotalPay(loan, rate, downPayment, term);
                total = Math.Round(total);

                double PMT = calcLoan.PMT(loan, rate, downPayment, term);
                PMT = Math.Round(PMT);


                //使用另一個視窗來展示數據
                loan_report repo = new loan_report();
                repo._txtLoan.Text = txtLoan.Text;
                repo._txtTerm.Text = txtTerm.Text;
                repo._txtRate.Text = txtRate.Text;
                repo._txtPMT.Text = Convert.ToString(PMT);
                repo._txtTotal.Text = Convert.ToString(total);
                repo.Show();

            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入正確格式的數字");
            }
            catch (Exception)
            {
                MessageBox.Show("發生不明錯誤>< 暫時無法使用");
            }
        }
    }
}
