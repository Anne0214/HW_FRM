using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_score
{
    public partial class frm_score : Form
    {
        public frm_score()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("成功");
        }
        //todo刻好畫面跟建好建構子了，要開始做互動
    }
}
