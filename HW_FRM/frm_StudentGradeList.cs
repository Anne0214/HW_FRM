using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HW_FRM
{
    public partial class frm_StudentGradeList : Form
    {
        public frm_StudentGradeList()
        {
            InitializeComponent();
            
        }



        List<Student> grades = new List<Student>(); //用來記錄學生成績
        private void NewRow(string Name, int Chi, int Eng, int Math, List<Student> grades,bool
            mode)
        { //此方法為要加入成績時使用
            Student student= new Student();
            student.Name = Name;
            student.scoreChi = Chi;
            student.scoreEng = Eng;
            student.scoreMath = Math;

            grades.Add(student); //放入紀錄學生成績用的list

            //總分
            int sum = Chi + Eng + Math;
            //平均
            double avg = sum / 3;


            //最高
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                ["國文"] = Chi,
                ["英文"] = Eng,
                ["數學"] = Math,
            };
            string maxSubject = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key; //使用aggregate來比大小
            int maxScore = dict[maxSubject];



            //最低
            string minSubject = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            int minScore = dict[minSubject];

            //將該學生的資料放一列到ListView顯示
            ListViewItem item0 = new ListViewItem();
            item0.SubItems[0].Text = student.Name;
            item0.SubItems.Add(student.scoreChi.ToString());
            item0.SubItems.Add(student.scoreEng.ToString());
            item0.SubItems.Add(student.scoreMath.ToString());
            item0.SubItems.Add(sum.ToString());
            item0.SubItems.Add(avg.ToString());
            item0.SubItems.Add(minSubject + minScore);
            item0.SubItems.Add(maxSubject + maxScore);

            if (mode == true) //表示是新資料，放最下面
            {
                listAll.Items.Add(item0);
            }
            else //表示要插入，放最上面
            {
                listAll.Items.Insert(0, item0);
            }
            if (grades.Count > 0)
            {  //真的有資料就讓這些按鈕可以按

                btnSum.Enabled = true;
                btnRemove.Enabled = true;
                btnInset.Enabled = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        { //確認是否有每項都填，有問題就要求要改。都填了之後才將成績加入
            try
            {
                string name = txtName.Text;
                int chi,math,eng;
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
                                NewRow(name, chi, eng, math, grades, true);
                            }
                        }
                    }

                }
            }
            catch (FormatException) { MessageBox.Show("請輸入正確的成績><"); }
            catch (Exception) { MessageBox.Show("發生不明錯誤，請稍後再試"); }
        }

        private void btnInset_Click(object sender, EventArgs e)
        { //跟btnAdd_Click長得差不多，只差在放入的位置
            try
            {
                string name = txtName.Text;
                int chi,eng,math;
                bool is_int_chi = int.TryParse(txtChi.Text, out chi);
                bool is_int_math = int.TryParse(txtMath.Text, out math);
                bool is_int_eng = int.TryParse(txtEng.Text, out eng);
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
                            NewRow(name, chi, eng, math, grades, false);
                        }
                    }
                }
            }           
            catch (Exception) { MessageBox.Show("發生不明錯誤，請稍後再試"); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        { //點擊移除紐時觸發的方法 會1.清除在listbox的顯示 2. 清除資料。作業示範沒做清除資料，只有清除顯示，但我很棒我會清
            try
            {
                listAll.Items[0].Remove(); //清除顯示
                grades.RemoveAt(grades.Count - 1); //清除儲存的資料
                if (grades.Count <= 0) //刪完後發現不能再刪，就讓按鈕關掉
                {
                    btnRemove.Enabled = false;
                }
                
            }
             
            catch (Exception) { MessageBox.Show("發生不明錯誤，請稍後再試"); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                //點擊搜尋後發生的方法
                //首先抓取要搜尋的分數上下限
                int bottom;
                bool is_int_bottom = int.TryParse(txtChiRange_bottom.Text, out bottom);
                int top;
                bool is_int_top = int.TryParse(txtChiRange_top.Text, out top);

                if (is_int_bottom == false || is_int_top == false)
                {
                    MessageBox.Show("請輸入整數喔");
                    return;
                }

                //抓出不符合搜尋結果的資料
                List<int> removeIndex = new List<int>(); //用此list紀錄非搜尋結果要的成績的位置(index)
                int i = 0; //用來記錄當前foreach跑到哪一項資料，該資料的index
                foreach (Student h in grades)
                { //歷遍每個成績，確定哪些成績是搜尋範圍外的，加入removeIndex

                    if (h.scoreChi < bottom | h.scoreChi > top)
                    {
                        removeIndex.Add(i); //搜尋範圍外的資料的index記入list裡
                    }
                    else
                    {
                        continue;
                    }
                    ++i; //要到下一個，所以增加

                }


                //刪除在listAll裡面，不符合搜尋範圍的成績
                int k = 0;  //每刪除一筆資料，index會變動，用k來矯正
                foreach (int j in removeIndex)
                {
                    listAll.Items[j - k].Remove();
                    k++;
                }
            }
            catch (Exception) { MessageBox.Show("發生不明錯誤，請稍後再試"); }

        }

        private void btnReset_Click(object sender, EventArgs e)
        { //清除每項資料
            listAll.Items.Clear();
            listSum.Items.Clear(); 
            grades.Clear();


            //按鈕回歸原始設定
            btnInset.Enabled = true;
            btnSum.Enabled = false;
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;

            //方便用戶接著輸入資料，清空輸入框
            txtChi.Text = "";
            txtMath.Text = "";
            txtEng.Text = "";
            txtName.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                //總分，歷遍grades這個list裡面所有學生的[科目成績]，進行加總
                //還有為了後面最高分與最低分比大小先建立list
                int sumChi = 0;
                int sumEng = 0;
                int sumMath = 0;
                List<int> gradesChi = new List<int>();
                List<int> gradesEng = new List<int>();
                List<int> gradesMath = new List<int>();
                foreach (Student h in grades)
                {
                    sumChi += h.scoreChi;
                    gradesChi.Add(h.scoreChi);
                };

                foreach (Student h in grades)
                {
                    sumEng += h.scoreEng;
                    gradesEng.Add(h.scoreEng);
                };

                foreach (Student h in grades)
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
                listSum.Items.Add(item1);



                //平均，將上述得到的[科目]的總成績，進行平均
                double avgChi = sumChi / 3;
                double avgEng = sumEng / 3;
                double avgMath = sumMath / 3;

                ListViewItem item2 = new ListViewItem();
                item2.SubItems[0].Text = "平均";
                item2.SubItems.Add(avgChi.ToString());
                item2.SubItems.Add(avgEng.ToString());
                item2.SubItems.Add(avgMath.ToString());
                listSum.Items.Add(item2);



                //最高分跟最低分，使用前面得到的list，進行比大小得到最高分跟最低分

                int maxChi = gradesChi.Max();
                int maxEng = gradesEng.Max();
                int maxMath = gradesMath.Max();

                int minMath = gradesMath.Min();
                int minEng = gradesEng.Min();
                int minChi = gradesChi.Min();

                ListViewItem item3 = new ListViewItem();
                item3.SubItems[0].Text = "最高分";
                item3.SubItems.Add(maxChi.ToString());
                item3.SubItems.Add(maxEng.ToString());
                item3.SubItems.Add(maxMath.ToString());
                listSum.Items.Add(item3);

                ListViewItem item4 = new ListViewItem();
                item4.SubItems[0].Text = "最低分";
                item4.SubItems.Add(minChi.ToString());
                item4.SubItems.Add(minEng.ToString());
                item4.SubItems.Add(minMath.ToString());
                listSum.Items.Add(item4);


                //調整按鈕
                btnSum.Enabled = false;
                btnAdd.Enabled = false;
                btnInset.Enabled = false;
                btnRemove.Enabled = false;
            }
            catch (Exception) { MessageBox.Show("發生不明錯誤，請稍後再試"); }
        }

    }
}
    

