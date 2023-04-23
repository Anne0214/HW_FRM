using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_FRM
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        Form main;

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.Close();
            }
            main = new frm_Hello();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.Close();
            }
            main = new Loan();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.Close();
            }
            main = new pos();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                 if (main != null)
            {
                main.Close();
            }
            main = new frm_score();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (main != null)
            {
                main.Close();
            }
            main = new frm_StudentGrade();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                if (main != null)
            {
                main.Close();
            }
            main = new frm_StudentGradeList();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.Close();
            }
            main = new frm_Method();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (main != null)
            {
                main.Close();
            }
            main = new frm_MyCalc();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (main != null)
            {
                main.Close();
            }
            main = new frm_ForDoWhile();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (main != null)
            {
                main.Close();
            }
            

            main = new frm_XOGame();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            if (main != null)
            {
                main.Close();
            }


            main = new frm_ScreenSaver();
            //main.MdiParent = this;
            //main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (main != null)
            {
                main.Close();
            }


            main = new frm_Notepad();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            

            if (main != null)
            {
                main.Close();
            }


            main = new frm_DrawPaint();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            

            if (main != null)
            {
                main.Close();
            }


            main = new frm_PictureViewer();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();

        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            if (main != null)
            {
                main.Close();
            }


            main = new frm_Guess();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();


        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.Close();
            }


            main = new frm_Alarm();
            main.MdiParent = this;
            main.Parent = this.splitContainer1.Panel2;
            main.Show();
        }

        
    }
}

