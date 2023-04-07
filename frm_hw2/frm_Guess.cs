using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_hw2
{
    public partial class frm_Guess : Form
    {
        
        public frm_Guess() //這個是父視窗
        {
            InitializeComponent();
            GuessGame.NewGame(); //初始化視窗的同時，我們要開啟遊戲，有了answer等等數值

        }
        
        
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            frm_Guess_Input frmInput=new frm_Guess_Input(this); //實體化子視窗，裡面的參數告訴我們當前的視窗是爸爸視窗
            frmInput.ShowDialog(); //開啟子視窗
            
        }

        public string setLabText
        {
            set
            {
                labInstruction.Text = value; //設定一個父視窗的屬性叫做setLabText。這個屬性的value會指定給labInstruction的文字
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是:" +  GuessGame.answer); //直接看答案，會取得GuessGame的靜態屬性，取的方法是class.屬性名稱
            GuessGame. NewGame(); //重新開始遊戲，看答案了就要重新遊戲
            labInstruction.Text = "已經重新出題，按挑戰開始"; //告訴用戶當前狀況
           
          
        }
    }
}
