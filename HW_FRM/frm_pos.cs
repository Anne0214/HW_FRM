using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HW_FRM
{
    public partial class pos : Form
    {
        

        public pos()
        {
            InitializeComponent();
           
        }

        Commodity cola = new Commodity(100, "可樂Cola", 0);
        Commodity congee = new Commodity(150, "典明粥", 0);
        Commodity pizza = new Commodity(200, "披薩Pizza", 0);
        Commodity tea = new Commodity(50, "阿帕茶Tea", 0);
        List<Commodity> JojoOrder = new List<Commodity>(); //假設這次訂單客戶名是JOJO，該list用來儲存買了哪些東西


        int TotalPrice; //紀錄花的總價

        public void AddToList(Commodity item, List<Commodity> order) 
        { //確定購買後，加入商品清單的方法，item為這次要加入的商品，order是要購買的商品清單
            if (order.Contains(item)) //前面是否已點擊過這次點擊的商品
            {
                item.count++; //有的情況下，該商品在order裡的count+1

                int position = order.IndexOf(item);  //找到該商品在order的位置
                listBox.Items.RemoveAt(position); //修改文字清單，刪除舊版的文字
                string NewOrder= item.name + " X" + item.count + ",共NT$" + item.count * item.price + " 元" + Environment.NewLine;
                listBox.Items.Insert(position, NewOrder); //插入新版文字
                    
            }
            else //還沒點過該商品的情況
            {if (listBox.Items.Contains( "尚未點餐")) //文字清單是空的，一個商品都沒有的情況
                {
                    listBox.Items.Clear(); //需要先清空文字清單的尚未點餐  
                }

                order.Add(item);
                item.count++;
                listBox.Items.Add(item.name + "  X" + item.count + ",共NT$" + item.price + " 元" + Environment.NewLine);

            }
            //更新總價格的顯示
            TotalPrice += item.price; 
            txtTotalPrice.Text = "NT$" + TotalPrice.ToString();
        }

        private void imgCola_Click(object sender, EventArgs e)
        { //每個被點擊商品都會觸發
            try //try-catch不寫在方法裡面是因為方法已經很長惹
            {
                AddToList(cola, JojoOrder);
            }
            catch (Exception) { MessageBox.Show("發生不知名錯誤，請稍後再嘗試> <"); }
        }

        private void imgCongee_Click(object sender, EventArgs e)
        {
            try
            {
                AddToList(congee, JojoOrder);
            }
            catch (Exception) { MessageBox.Show("發生不知名錯誤，請稍後再嘗試> <"); }

        }

        private void imgPizza_Click(object sender, EventArgs e)
        {
            try
            {
                AddToList(pizza, JojoOrder);
            }
            catch (Exception) { MessageBox.Show("發生不知名錯誤，請稍後再嘗試> <"); }
        }

        private void imgTea_Click(object sender, EventArgs e)
        {
            try
            {
                AddToList(tea, JojoOrder);
            }
            catch (Exception) { MessageBox.Show("發生不知名錯誤，請稍後再嘗試> <"); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                //清空清單顯示，並顯示尚未點餐
                listBox.Items.Clear();
                listBox.Items.Add("尚未點餐");


                //清空訂單資料
                foreach (Commodity g in JojoOrder)
                {
                    g.count = 0;
                }
                JojoOrder.Clear();

                //清空總價
                TotalPrice = 0;
                txtTotalPrice.Text = "NT$" + TotalPrice.ToString();
            }
            catch (Exception) { MessageBox.Show("發生不知名錯誤，請稍後再嘗試> <"); }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            try
            {
                if (TotalPrice > 0)
                {
                    MessageBox.Show("總金額:NT$" + TotalPrice.ToString());
                }
                else
                {  //價格為0需提醒尚未點餐
                    MessageBox.Show("尚未點餐!");
                }
            }
            catch (Exception) { MessageBox.Show("發生不知名錯誤，請稍後再嘗試> <"); }


        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            try
            {
                if (TotalPrice > 0)
                {
                    MessageBox.Show("總金額:NT$" + TotalPrice.ToString() + Environment.NewLine + "折扣後金額:NT$" + (0.9 * TotalPrice).ToString());
                }
                else
                {//價格為0需提醒尚未點餐
                    MessageBox.Show("尚未點餐!");
                }
            }
            catch (Exception) { MessageBox.Show("發生不知名錯誤，請稍後再嘗試> <"); }
        }
    }
}
