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
    public partial class frm_Notepad : Form
    {
        public frm_Notepad()
        {
            InitializeComponent();
        }

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
            if (textBox.WordWrap == true)
            {
                textBox.WordWrap = false;
            }
            else
            {
                textBox.WordWrap = true; //todo 這寫法太智障，感覺有其他寫法，再看看
            }
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
               OpenFileDialog  ofd = new OpenFileDialog();   
            ofd.ShowDialog();
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
    }
}
