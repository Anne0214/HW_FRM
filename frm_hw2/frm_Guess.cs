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
        
        public frm_Guess()
        {
            InitializeComponent();
            GuessGame.NewGame();

        }
        
        
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            frm_Guess_Input frmInput=new frm_Guess_Input(this);
            frmInput.ShowDialog();
            
        }

        public string setLabText
        {
            set
            {
                labInstruction.Text = value;
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是:" +  GuessGame.answer);
            GuessGame. NewGame(); //重新開始遊戲
            labInstruction.Text = "已經重新出題，按挑戰開始";
           
          
        }
    }
}
