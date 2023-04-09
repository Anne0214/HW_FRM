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
    public partial class frm_Hello : Form
    {
        public frm_Hello()
        {
            InitializeComponent();
        }

        private void btnHero_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" | txtEngName.Text == "" | txtGender.Text == "" | txtSign.Text == "")
            {
                MessageBox.Show("唉呀，有資料沒有填喔!");
            }
            else
            {
                MessageBox.Show(
                    $"Hello, {txtName.Text}\n歡迎加入勇者的隊伍，就叫你{txtEngName.Text}吧! \n性別{txtGender.Text}，星座是{txtSign.Text}對吧 \n接下來請多多指教!");
            }
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" | txtEngName.Text == "" | txtGender.Text == "" | txtSign.Text == "")
            {
                MessageBox.Show("唉呀，有資料沒有填喔!");
            }
            else
            {
                MessageBox.Show(
                    $"Hi, {txtName.Text}\n歡迎加入後勤，就叫你{txtEngName.Text}吧! \n性別{txtGender.Text}，星座是{txtSign.Text}對吧 \n接下來請多多指教!");
            }
        }

    }
}
