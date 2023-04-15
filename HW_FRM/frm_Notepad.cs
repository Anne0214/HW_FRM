using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HW_FRM
{
    public partial class frm_Notepad : Form
    {
        public frm_Notepad()
        {
            InitializeComponent();
        }
        string filePath = "";  //存放當前開啟的文件位置


        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            ColorDialog colorDialog = new ColorDialog();
            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                textBox.ForeColor = color;
            }
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDialog.Font;
                textBox.Font = font;
            }
            
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                textBox.WordWrap = !textBox.WordWrap;
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Red;
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Black;
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("恩", "關於這個Notepad");
        }

        private void OpenFile() //開啟檔案的方法
        {
            OpenFileDialog ofd = new OpenFileDialog(); //叫出開檔案的視窗選檔案
            ofd.Filter = "Text Files(.txt)|**.txt"; //只能開文字檔
            ofd.Multiselect = false; //只能選一個檔案 
            if (ofd.ShowDialog() == DialogResult.OK) //用戶選好檔案
            {
                filePath = ofd.FileName; // 取得用戶選取的檔案位置

                StreamReader rd = new StreamReader(filePath, Encoding.UTF8);
                textBox.Text = rd.ReadToEnd(); //讀檔放到編輯的區域
                rd.Close();

                labStatus.Text = "開啟成功";
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (filePath == "" & textBox.Text == "")
                { //前面都沒有開啟過任何檔案、也沒有在當前文字區有編輯的狀況
                    OpenFile();
                }
                else
                { //前面有開啟過檔案的狀況，或是文字區已經編輯過的狀況，必須詢問是否要開啟檔案
                    DialogResult t = MessageBox.Show("這樣剛剛編輯的都會消失喔><不會儲存喔", "確定要開啟檔案嗎?", MessageBoxButtons.YesNoCancel);
                    if (t == DialogResult.Yes) //仍要開啟的狀況就執行開啟檔案的流程
                    {
                        OpenFile();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("發生不明錯誤(･8･)請稍後嘗試");
            }

        }
   
        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();    
            printDialog.ShowDialog();
        }



        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();   
            printPreviewDialog.ShowDialog();
        }



        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.SelectAll();
        }




        private void Paste_Click(object sender, EventArgs e)
        { //先判斷剪貼簿當中是否有東西
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                //GetDataObject是拿剪貼簿中的東西
                //GetDataPresent是轉換成指定格式
                
                if (textBox.SelectionLength > 0)//判斷是否有選中textbox中的文字
                {
                    if (MessageBox.Show("要讓貼上的文字覆蓋當前所選的文字嗎", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        textBox.SelectionStart = textBox.SelectionStart + textBox.SelectionLength; //todo保護住當前所選的部分，雖然不太懂為甚麼是這個寫法，但我太困了沒有腦子想
                    }
                    textBox.Paste(); //無論有無選中文字，最後都要貼上
                }
            }
            

        }

        private void Cut_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "") 
            {
                textBox.Cut();
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0) //選中的長度不為0。
            {
                textBox.Copy();
            }
        }

      
        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.CanUndo == false) //判斷是否有可以復原的部分
            {
                textBox.Undo(); //執行undo
                textBox.ClearUndo(); //清空undo，避免取消undo
                 
            }
        }


     
        private void Timer_TimeDisplay(object sender, EventArgs e)
        { //左下角當前時間的事件
            labTime.Text = DateTime.Now.ToString("tt HH:mm:ss");
         
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (filePath == "")
                { //寫新檔要儲存的情況
                    SaveFileDialog sfd = new SaveFileDialog(); //詢問要儲存的位置
                    sfd.Filter = "Text Files(.txt)|**.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        filePath = sfd.FileName;
                        StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8);
                        writer.Write(textBox.Text);
                        writer.Close();
                        labStatus.Text = "儲存成功";
                    }
                }
                else
                {//開啟舊檔要儲存的情況，原檔案位置直接存


                    StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8);
                    writer.WriteLine(textBox.Text);
                    writer.Close();

                    labStatus.Text = "儲存成功";


                }
            }
            catch (Exception)
            {
                MessageBox.Show("發生不明錯誤(･8･)請稍後嘗試");
            }
        }

        

        private void NewFile_Click(object sender, EventArgs e)
        {
            DialogResult t =MessageBox.Show("這樣剛剛編輯的都會消失喔><不會儲存喔", "確定要新增檔案嗎?", MessageBoxButtons.YesNoCancel);
            if (t == DialogResult.Yes)
            {
                filePath = "";
                textBox.Text = "";
                labStatus.Text = "新增成功";
            }
            
        }

 
        int i = 0; //用於控制status出現的時長
        bool colorSwitch = false;  //用來做labStatus的醜死人效果
        private void timer_Status(object sender, EventArgs e)
        { //這個timer是用來做右下角status的效果，要給使用者反饋，但我怕做了沒人發現，於是設定超醜紅綠閃爍
            labStatus.ForeColor = (colorSwitch ? Color.Red : Color.Green);
            colorSwitch = !colorSwitch;

            if (labStatus.Text.Length > 0 & i < 80)
            {
                i++;
            }
            else
            {
                labStatus.Text = "";
            }
        }
    }
}
