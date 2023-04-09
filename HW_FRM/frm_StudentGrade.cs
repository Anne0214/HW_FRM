using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HW_FRM
{
    public partial class frm_StudentGrade : Form
    {
        
    public frm_StudentGrade()
        {
            InitializeComponent();
        }
      List<Student> grades= new List<Student>();
        

    public void newRow(string Name,int Chi, int Eng, int Math,List<Student> grades)
        {
            Student student = new Student();
            student.Name = Name;
            student.scoreChi = Chi;
            student.scoreEng = Eng;
            student.scoreMath = Math;

            grades.Add(student);

            //總分
            int sum = Chi + Eng+ Math;
            //平均
            decimal avg = decimal.Round(sum / 3,2); 


            //最低
            var dict = new Dictionary<string, int>
            {
                ["國文"] = Chi,
                ["英文"] = Eng,
                ["數學"]=Math,
            };
            string maxSubject = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            int maxScore = dict[maxSubject];

            

            //最高
            string minSubject = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            int minScore = dict[minSubject];


            ListViewItem item0 = new ListViewItem();
            item0.SubItems[0].Text = student.Name;
            item0.SubItems.Add(student.scoreChi.ToString());
            item0.SubItems.Add(student.scoreEng.ToString());
            item0.SubItems.Add(student.scoreMath.ToString());
            item0.SubItems.Add(sum.ToString());
            item0.SubItems.Add(avg.ToString());
            item0.SubItems.Add(minSubject + minScore);
            item0.SubItems.Add(maxSubject+ maxScore);
            listAll.Items.Add(item0);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("請輸入名字噢");
            }
            else
            {
                string name = txtName.Text;
                if (txtChi.Text=="") {
                    MessageBox.Show("請輸入國文成績噢");
                } else {
                    int chi = int.Parse(txtChi.Text);
                    if (txtEng.Text =="")
                    {
                        MessageBox.Show("請輸入英文成績噢");
                    }
                    else
                    {
                        int eng = int.Parse(txtEng.Text);
                        if (txtMath.Text=="")
                        {
                            MessageBox.Show("請輸入數學成績噢");
                        }
                        else
                        {
                            int math = int.Parse(txtMath.Text);
                            newRow(name, chi, eng, math,grades);
                            if (grades.Count > 0)
                            {
                                btnSummary.Enabled = !btnSummary.Enabled;
                            } //todo應該有只放一個地方的方法QQ
                        }
                    }
                }
            }
            
            
            
            
            


        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int chi= random.Next(0, 100);  
            int eng= random.Next(0, 100);
            int math= random.Next(0, 100);
            int name_int = grades.Count()+1;
            string name = name_int.ToString();
            newRow(name, chi, eng, math
                , grades);
            if (grades.Count > 0)
            {
                btnSummary.Enabled = !btnSummary.Enabled;
            } //todo應該有只放一個地方的方法QQ

        }

        private void btnRadeom20_Click(object sender, EventArgs e)
        {
            Random random = new Random(); //不知道為甚麼，但要放在外面
            for (int i=0;i<20;i++) {
                
                int chi = random.Next(0, 100);
                int eng = random.Next(0, 100);
                int math = random.Next(0, 100);
                int name_int = grades.Count() + 1;
                string name = name_int.ToString();
                newRow(name, chi, eng, math,grades);
            }
            if (grades.Count > 0)
            {
                btnSummary.Enabled = !btnSummary.Enabled;
            } //todo應該有只放一個地方的方法QQ

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listAll.Items.Clear();
            listAll.Refresh();
            grades.Clear();

            listSummary.Items.Clear();
            listSummary.Refresh();
            btnSummary.Enabled = !btnSummary.Enabled;
            btnAdd.Enabled = !btnAdd.Enabled;
            btnRadeom20.Enabled = !btnRadeom20.Enabled;
            btnRandom.Enabled = !btnRandom.Enabled;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            //總分，歷遍grades這個list裡面所有學生的[科目成績]，進行加總
            //還有為了後面最高分與最低分比大小先建立list
            int sumChi=0;
            int sumEng=0;
            int sumMath=0;
            List<int> gradesChi = new List<int>();
            List<int> gradesEng = new List<int>();
            List<int> gradesMath = new List<int>();
            foreach (var h in grades) {
                sumChi += h.scoreChi;
                gradesChi.Add(h.scoreChi);
            };

            foreach (var h in grades)
            {
                sumEng += h.scoreEng;
                gradesEng.Add(h.scoreEng);
            };

            foreach (var h in grades)
            {
                sumMath += h.scoreMath;
                gradesMath.Add(h.scoreMath);
            };

            //建立總分的item，放入listview
            ListViewItem item1 = new ListViewItem();
            item1.SubItems[0].Text = "總分";
            item1.SubItems.Add(sumChi.ToString());
            item1.SubItems.Add(sumEng.ToString());
            item1.SubItems.Add(sumMath.ToString());
            listSummary.Items.Add(item1);



            //平均，將上述得到的[科目]的總成績，進行平均
            decimal avgChi = decimal.Round(sumChi / 3,2);
            decimal avgEng = decimal.Round(sumEng / 3, 2);
            decimal avgMath = decimal.Round(sumMath / 3, 2);

            ListViewItem item2 = new ListViewItem();
            item2.SubItems[0].Text = "平均";
            item2.SubItems.Add(avgChi.ToString());
            item2.SubItems.Add(avgEng.ToString());
            item2.SubItems.Add(avgMath.ToString());
            listSummary.Items.Add(item2);
            //最高分跟最低分，使用前面得到的list，進行比大小得到最高分跟最低分
            
            


          int maxChi = gradesChi.Max();
            int maxEng = gradesEng.Max();
            int maxMath = gradesMath.Max();

            int minMath = gradesMath.Min();
            int minEng = gradesEng.Min();
            int minChi = gradesChi.Min();

            ListViewItem item3= new ListViewItem();
            item3.SubItems[0].Text = "最高分";
            item3.SubItems.Add(maxChi.ToString());
            item3.SubItems.Add(maxEng.ToString());
            item3.SubItems.Add(maxMath.ToString());
            listSummary.Items.Add(item3);

            ListViewItem item4 = new ListViewItem();
            item4.SubItems[0].Text = "最低分";
            item4.SubItems.Add(minChi.ToString());
            item4.SubItems.Add(minEng.ToString());
            item4.SubItems.Add(minMath.ToString());
            listSummary.Items.Add(item4);

            btnAdd.Enabled = !btnAdd.Enabled;
            btnRadeom20.Enabled = !btnRadeom20.Enabled;
            btnRandom.Enabled = !btnRandom.Enabled;

        }

    }
}
