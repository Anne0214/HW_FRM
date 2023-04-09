using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static HW_FRM.Student;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_FRM
{
    public partial class frm_score : Form
    {
        public frm_score()
        {
            InitializeComponent();
        }
        Student stupid= new Student();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                stupid.Name = txtName.Text;
                stupid.scoreChi = int.Parse(txtChi.Text);
                stupid.scoreMath = int.Parse(txtMath.Text);
                stupid.scoreEng = int.Parse(txtEng.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入正確格式的資料");
            }
    }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.Text
            = string.Format("姓名：{0}\n國文：{1}\n數學：{2}\n英文：{3}", stupid.Name, stupid.scoreChi, stupid.scoreMath, stupid.scoreEng); //todo媽的一直換不了行

        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            int[] array = new int[] { stupid.scoreChi, stupid.scoreMath, stupid.scoreEng };
            txtSpecial.Text = String.Format("最高分科目成績為:{0}\n最低分科目成績為:{1}", array.Max(),array.Min()); //todo 不能換行要再調整
        }
    }
}
