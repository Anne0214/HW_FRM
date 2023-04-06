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
    public partial class frm_Guess_Input : Form
    {
        public frm_Guess_Input()
        {
            InitializeComponent();
        }

        GuessGame game2= new GuessGame();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int input;
            
            bool isNum = int.TryParse(txtInput.Text, out input);
            if (isNum==false || input>100 || input<1)
            {
                MessageBox.Show("請輸入1~100的數字");
            }
            else
            {
                game2.Result(input);
          
            }
        }
    }
}
