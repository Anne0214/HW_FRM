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
    public partial class frm_DrawPaint : Form
    {
        Graphics g;
        Pen pen;
        
        public frm_DrawPaint()
        {
            InitializeComponent();
            g = this.CreateGraphics(); //為這個視窗建立畫板
            pen = new Pen(Color.Black, 1); //初始畫筆
        }

        bool isMouseDown=false; //紀錄游標長按與否的狀況
        List<Point> points = new List<Point>(); //紀錄游標點擊放開的位置

        

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()== DialogResult.OK)
            {
                Color color= colorDialog.Color;
                colorBox.BackColor = color;
                pen.Color = color;
            }
        }

        private void brushBar_Scroll(object sender, EventArgs e)
        {
            brushSize.Text = brushBar.Value.ToString();
            pen.Width=brushBar.Value;
        }

        private void frm_DrawPaint_MouseDown(object sender, MouseEventArgs e)
        {//當點擊時
            try
            {
                points.Add(new Point(e.X, e.Y)); //紀錄點擊的位置
                isMouseDown = true; //變成true
            }
            catch (Exception) { MessageBox.Show("發生不明錯誤(･8･)請稍後再試"); }
        }

        private void frm_DrawPaint_MouseMove(object sender, MouseEventArgs e)
        {//當游標移動時
            try
            {
                points.Add(new Point(e.X, e.Y));  //新增一個當前位置
                if (isMouseDown)//當有之前發生過游標點擊時，就可以開始畫線
                {//從上次點擊位置(或是游標上個經過的位置)，畫到游標當前位置)
                    g.DrawLine(pen, points[points.Count - 2], points[points.Count - 1]);
                }
            }
            catch (Exception) { MessageBox.Show("發生不明錯誤(･8･)請稍後再試"); }


        }

        private void frm_DrawPaint_MouseUp(object sender, MouseEventArgs e)//點擊後放開游標會觸發的事件
        {//當游標放開時
            try
            {
                if (isMouseDown)
                { //如果是前面發生過點擊游標
                    points.Add(new Point(e.X, e.Y)); //新增當前位置
                    g.DrawLine(pen, points[points.Count - 2], points[points.Count - 1]); //最後一個點是放開的位置，意思是從上次移動位置畫到這次放開的位置
                }

                isMouseDown = false; //改為放開，就不會再畫了
            }
            catch (Exception) { MessageBox.Show("發生不明錯誤(･8･)請稍後再試"); }
        }
    }
}
