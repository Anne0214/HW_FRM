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

        bool isMouseDown=false;
        List<Point> points = new List<Point>();

        

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
        {
            points.Add(new Point(e.X,e.Y)); //紀錄點下的位置
            isMouseDown = true; //變成true

        }

        private void frm_DrawPaint_MouseMove(object sender, MouseEventArgs e)
        {
            
            points.Add(new Point(e.X,e.Y) ); //todo 可以用e.Location來寫嗎
            if (isMouseDown)//當有前面的游標點擊時就可以開始畫線
            {
                g.DrawLine(pen, points[points.Count - 2], points[points.Count - 1]); //用pen在g上畫圖，當游標移動且確實有前面點擊時，就會開始畫線，從上次點擊位置(或是游標經過的位置，畫到游標當前移動的位置)
            }

            

        }

        private void frm_DrawPaint_MouseUp(object sender, MouseEventArgs e)//點擊後放開游標會觸發的事件
        {
            if (isMouseDown)
            {
                points.Add(new Point(e.X, e.Y));
                g.DrawLine(pen, points[points.Count-2], points[points.Count - 1]); //最後一個點是放開的位置，意思是從上次移動位置畫到這次放開的位置
            }

            isMouseDown = false;
        }
    }
}
