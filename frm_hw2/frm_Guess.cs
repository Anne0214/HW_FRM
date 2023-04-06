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
    public partial class frm_Guess : Form
    {
        GuessGame game;
        public frm_Guess()
        {
            InitializeComponent();
            game.NewGame();
        }
        
        
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            frm_Guess_Input frmInput=new frm_Guess_Input();
            frmInput.ShowDialog();
            
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是:" +  GuessGame.answer);
            game.NewGame();
            labInstruction.Text = GuessGame.instruction;
          
        }
    }
}
