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

namespace frm_pose
{
    public partial class pos : Form
    {
        commodity cola = new commodity(100,"可樂Cola",0);
        commodity congee = new commodity(150, "典明粥", 0);
        commodity pizza = new commodity(200, "披薩Pizza", 0);
        commodity tea = new commodity(50, "阿帕茶Tea", 0);
        List<commodity> JojoOrder= new List<commodity>();
        
        
        int TotalPrice;

        public pos()
        {
            InitializeComponent();
           
        }
        
        public void CreateList(commodity Item, List<commodity> order)
        {
            if (order.Contains(Item)) //orderlist是否包含了這次點及的商品)
            {
                Item.count++; //包含的情況下，該item的count+1

                int position = order.IndexOf(Item);
                listBox.Items.RemoveAt(position);
                string NewOrder= Item.name + " X" + Item.count + ",共NT$" + Item.count * Item.price + " 元" + Environment.NewLine;
                listBox.Items.Insert(position, NewOrder);
                
                //txtList.Text = null; 不用清空了
                //foreach (commodity h in order)
                //{
                    
                //    string line = h.name + " X" + h.count + ",共NT$" + h.count * h.price + " 元" + Environment.NewLine; //各自價格跟各自的數量要進來
                //    txtList.Text += line;

                //}
            }
            else
            {if (listBox.Items.Contains( "尚未點餐"))
                {
                    listBox.Items.Clear();
                    JojoOrder.Add(Item);
                    Item.count++;
                    listBox.Items.Add(Item.name + "  X" + Item.count + ",共NT$" + Item.price + " 元" + Environment.NewLine);
                }
                else
                {
                    JojoOrder.Add(Item);
                    Item.count++;
                    listBox.Items.Add(Item.name + "  X" + Item.count + ",共NT$" + Item.price + " 元" + Environment.NewLine);
                }
                

            }
            
        }

        private void imgCola_Click(object sender, EventArgs e)
        {
            CreateList(cola,JojoOrder);
            TotalPrice += cola.price;
            txtTotalPrice.Text = "NT$" + TotalPrice.ToString();

        }

        private void imgCongee_Click(object sender, EventArgs e)
        {
            CreateList(congee,JojoOrder);
            TotalPrice += congee.price;
            txtTotalPrice.Text = "NT$" + TotalPrice.ToString();
        }

        private void imgPizza_Click(object sender, EventArgs e)
        {
            CreateList(pizza,JojoOrder);
            TotalPrice += pizza.price;
            txtTotalPrice.Text = "NT$" + TotalPrice.ToString();
        }

        private void imgTea_Click(object sender, EventArgs e)
        {
            CreateList(tea,JojoOrder);
            TotalPrice += tea.price;
            txtTotalPrice.Text = "NT$"+TotalPrice.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add("尚未點餐");
            foreach (var g in JojoOrder)
            {
                g.count = 0;
            }
                JojoOrder.Clear();
            TotalPrice = 0;
            txtTotalPrice.Text = "NT$"+TotalPrice.ToString();

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (TotalPrice !=0)
            {
                MessageBox.Show("總金額:NT$" + TotalPrice.ToString());
            }
            else
            {
                MessageBox.Show("尚未點餐!");
            }

            

        }

        private void btnCard_Click(object sender, EventArgs e)
        { if (TotalPrice != 0)
            {
                MessageBox.Show("總金額:NT$" + TotalPrice.ToString() + Environment.NewLine + "折扣後金額:NT$" + (0.9 * TotalPrice).ToString());
            }
            else
            {
                MessageBox.Show("尚未點餐!");
            }
            
        }
    }
}
