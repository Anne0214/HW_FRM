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

namespace HW_FRM
{
    public partial class frm_Guess_Input : Form
    {
        public frm_Guess_Input(frm_Guess Parentform) //todo有參數是父視窗
        {
            InitializeComponent();
            this.Tag = Parentform; //todo待了解意思
        }

        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int input;
            
            bool isNum = int.TryParse(txtInput.Text, out input);
            if (isNum==false || input>=GuessGame.max || input<=GuessGame.min)
            {
                MessageBox.Show($"請輸入{GuessGame.min}~{GuessGame.max}的數字"); //todo 這邊要隨當前範圍要改變
            }
            else
            {
                bool victory;
                string result= GuessGame.Result(input,out victory);
                if (victory == true)
                {
                    MessageBox.Show(result);
                    ((frm_Guess)this.Tag).setLabText = "已經重新出數字，輸入1~100的數字開始新遊戲";
                    txtInput.Text = "";
                }
                else { ((frm_Guess)this.Tag).setLabText = result; }
                
                
                
                
          
            }
        }
    }
}
