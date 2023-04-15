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
        Student student= new Student(); //只有一個學生，此處new一個實體
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int chi, math, eng;
                bool is_int_chi = int.TryParse(txtChi.Text, out chi);
                bool is_int_math = int.TryParse(txtMath.Text, out math);
                bool is_int_eng = int.TryParse(txtEng.Text, out eng);
                

                if (name == "")
                {
                    MessageBox.Show("請輸入學生名稱喔(ノ▼Д▼)ノ");
                }
                else
                {
                    if (is_int_chi == false)
                    {
                        MessageBox.Show("請輸入正確的國文成績(ノ▼Д▼)ノ");
                    }
                    else
                    {
                        if (is_int_eng == false)
                        {
                            MessageBox.Show("請輸入正確的英文成績(ノ▼Д▼)ノ");
                        }
                        else
                        {
                            if (is_int_math == false)
                            {
                                MessageBox.Show("請輸入正確的數學成績(ノ▼Д▼)ノ");
                            }
                            else
                            {
                                student.Name = name;
                                student.scoreChi = chi;
                                student.scoreEng = eng;
                                student.scoreMath = math;
                            }
                            
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("發生不明錯誤，請稍後再試");
            }
    }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
            txtDisplay.Text = $"姓名：{student.Name}{Environment.NewLine}國文：{student.scoreChi}{Environment.NewLine}數學：{student.scoreMath}{Environment.NewLine}英文：{student.scoreEng}";
            //不知道為甚麼這樣寫才能換行，昏惹
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            int[] array = new int[] { student.scoreChi, student.scoreMath, student.scoreEng };
            txtSpecial.Text = $"最高分科目成績為:{array.Max()}{Environment.NewLine}最低分科目成績為:{array.Min()}"; 
        }
    }
}
