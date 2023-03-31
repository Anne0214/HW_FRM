using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace frm_loan
{
    internal class calc_loan
    {
        public double monthlyRate(double rate, double term) //回傳月利率
        { //term單位年，rate為年利率，有小數點
            double numerator = Math.Pow(1+rate / 12,term*12);
            numerator = numerator * (rate / 12);
            double denominator = Math.Pow(1 + rate / 12, term * 12);
            denominator = denominator - 1;
            return numerator / denominator;
          

        }
        public double PMT(double loan,double rate, double downPayment,double term) //回傳每月付的金額
        {
            double mRate = monthlyRate(rate, term);
            return (loan - downPayment) * mRate;
        }
        public double totalPay(double loan, double rate, double downPayment, double term) //回傳總共付的金額
        {//todo可能有錯
            double mRate = monthlyRate(rate, term);
            double calc=PMT(loan, rate, downPayment, term);
            calc = calc * term * 12;
            return calc;
        }
    }
}
