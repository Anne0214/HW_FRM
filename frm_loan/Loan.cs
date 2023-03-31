using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_loan
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
            
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            //todo 此處待優化
            double downPayment = Convert.ToDouble(txtDownPayment.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            rate = rate * 0.01;
            double term = Convert.ToDouble(txtTerm.Text);
            double loan = Convert.ToDouble(txtLoan.Text);

            calc_loan calcLoan = new calc_loan();

            double PMT = calcLoan.PMT(loan, rate, downPayment, term);
            PMT = Math.Round(PMT);
            MessageBox.Show("月付額:" + PMT + "元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        { //todo此處待優化
            double downPayment = Convert.ToDouble(txtDownPayment.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            rate = rate * 0.01;
            double term = Convert.ToDouble(txtTerm.Text);
            double loan = Convert.ToDouble(txtLoan.Text);

            calc_loan calcLoan = new calc_loan();
            double result = calcLoan.totalPay(loan, rate, downPayment, term);
            result=Math.Round(result);
            MessageBox.Show("總付款:" + result + "元");

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            double downPayment = Convert.ToDouble(txtDownPayment.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            rate = rate * 0.01;
            double term = Convert.ToDouble(txtTerm.Text);
            double loan = Convert.ToDouble(txtLoan.Text);

            calc_loan calcLoan = new calc_loan();
            double total = calcLoan.totalPay(loan, rate, downPayment, term);
            total = Math.Round(total);

            double PMT = calcLoan.PMT(loan, rate, downPayment, term);
            PMT = Math.Round(PMT);

            loan_report repo = new loan_report();
            repo._txtLoan.Text = txtLoan.Text;
            repo._txtTerm.Text = txtTerm.Text;
            repo._txtRate.Text = txtRate.Text;
            repo._txtPMT.Text = Convert.ToString(PMT);
            repo._txtTotal.Text = Convert.ToString(total);
            repo.Show();
        }
    }
}
