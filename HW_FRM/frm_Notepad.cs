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
        String filePath = "";
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

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

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<h1>關於</h1><p>我困困</p>", "關於這個Notepad");//todo 這邊要做次標題，但我太困之後再做
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            if (filePath == "" & textBox.Text == "")
            { //前面都沒有開啟過任何檔案、也沒有在當前文字區編輯的狀況
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files(.txt)|**.txt"; //只能開文字檔
                ofd.Multiselect = false; //只能選一個檔案 
                if (ofd.ShowDialog() == DialogResult.OK) //用戶選好檔案
                {
                    filePath = ofd.FileName; // 取得用戶選取的檔案名

                    StreamReader rd = new StreamReader(filePath, Encoding.UTF8);
                    textBox.Text = rd.ReadToEnd();
                    rd.Close();
                    
                    labStatus.Text = "開啟成功";
                }
            }
            else
            { //前面有開啟過檔案的狀況，必須詢問是否要開啟檔案
                DialogResult t = MessageBox.Show("這樣剛剛編輯的都會消失喔><不會儲存喔", "確定要開啟檔案嗎?", MessageBoxButtons.YesNoCancel);
                if (t == DialogResult.Yes) //仍要開啟的狀況就執行開啟檔案的流程
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Text Files(.txt)|**.txt"; //只能開文字檔
                    ofd.Multiselect = false; //只能選一個檔案 
                    if (ofd.ShowDialog() == DialogResult.OK) //用戶選好檔案
                    {
                        filePath = ofd.FileName; // 取得用戶選取的檔案名

                        StreamReader rd = new StreamReader(filePath, Encoding.UTF8);
                        textBox.Text = rd.ReadToEnd();
                        rd.Close();
                        labStatus.Text = "開啟成功";
                    }
                }

            }

        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath == "" & textBox.Text == "")
            { //前面都沒有開啟過任何檔案、也沒有在當前文字區編輯的狀況
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files(.txt)|**.txt"; //只能開文字檔
                ofd.Multiselect = false; //只能選一個檔案 
                if (ofd.ShowDialog() == DialogResult.OK) //用戶選好檔案
                {
                    filePath = ofd.FileName; // 取得用戶選取的檔案名

                    StreamReader rd = new StreamReader(filePath, Encoding.UTF8);
                    textBox.Text = rd.ReadToEnd();
                    rd.Close();
                    labStatus.Text = "開啟成功";
                }
            }
            else
            { //前面有開啟過檔案的狀況，必須詢問是否要開啟檔案
                DialogResult t = MessageBox.Show("這樣剛剛編輯的都會消失喔><不會儲存喔", "確定要開啟檔案嗎?", MessageBoxButtons.YesNoCancel);
                if (t == DialogResult.Yes) //仍要開啟的狀況就執行開啟檔案的流程
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Text Files(.txt)|**.txt"; //只能開文字檔
                    ofd.Multiselect = false; //只能選一個檔案 
                    if (ofd.ShowDialog() == DialogResult.OK) //用戶選好檔案
                    {
                        filePath = ofd.FileName; // 取得用戶選取的檔案名

                        StreamReader rd = new StreamReader(filePath, Encoding.UTF8);
                        textBox.Text = rd.ReadToEnd();
                        rd.Close();
                        labStatus.Text = "開啟成功";
                    }
                }

            }

        }

        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();    
            printDialog.ShowDialog();
        }

        private void 列印PToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();   
            printPreviewDialog.ShowDialog();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<h1>關於</h1><p>我困困</p>", "關於這個Notepad");//todo 這邊要做次標題，但我太困之後再做
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.SelectAll();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0) //選中的長度不為0。
            {
                textBox.Copy();
            }
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            if(textBox.SelectedText !="") //todo只要選中的文字不是空白。跟複製的差別應該是剪下可以接受空白，不是很懂，再說
            {
                textBox.Cut();
            }
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        { //先判斷剪貼簿當中是否有東西
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                //GetDataObject是拿剪貼簿中的東西
                //GetDataPresent是轉換成指定格式
                //todo 不知道為啥要用DataFormat
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

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "") //todo只要選中的文字不是空白。跟複製的差別應該是剪下可以接受空白，不是很懂，再說
            {
                textBox.Cut();
            }
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0) //選中的長度不為0。
            {
                textBox.Copy();
            }
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "") //todo只要選中的文字不是空白。跟複製的差別應該是剪下可以接受空白，不是很懂，再說
            {
                textBox.Cut();
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

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo不想被叫老師的祐辰沒做，但是感覺可以做做看，不過好複雜，之後再說
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("tt HH:mm:ss");
         
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            { //寫新檔要儲存的情況
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files(.txt)|**.txt";
                if (sfd.ShowDialog()== DialogResult.OK)
                { filePath= sfd.FileName;
                    StreamWriter writer = new StreamWriter(filePath,false, Encoding.UTF8);
                    writer.Write(textBox.Text);
                    writer.Close();
                    labStatus.Text = "儲存成功";
                }
            }
            else
            {//開啟舊檔要儲存的情況


                StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8);
                writer.WriteLine(textBox.Text);
                writer.Close();
                
                labStatus.Text = "儲存成功";


            }
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            { //寫新檔要儲存的情況
                SaveFileDialog sfd = new SaveFileDialog();
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
            {//開啟舊檔要儲存的情況


                StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8);
                writer.WriteLine(textBox.Text);
                writer.Close();
                labStatus.Text = "儲存成功";


            }
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult t =MessageBox.Show("這樣剛剛編輯的都會消失喔><不會儲存喔", "確定要新增檔案嗎?", MessageBoxButtons.YesNoCancel);
            if (t == DialogResult.Yes)
            {
                filePath = "";
                textBox.Text = "";
                labStatus.Text = "新增成功";
            }
            
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("這樣剛剛編輯的都會消失喔><不會儲存喔", "確定要新增檔案嗎?", MessageBoxButtons.YesNoCancel);
            if (t == DialogResult.Yes)
            {
                filePath = "";
                textBox.Text = "";
                labStatus.Text = "新增成功";
            }

        }
        int i = 0; //用於控制status出現的時長
        bool colorSwitch = false;  //用來做labStatus的醜死人效果
        private void timeStatus_Tick(object sender, EventArgs e)
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
