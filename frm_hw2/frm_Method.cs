using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace frm_hw2
{
    public partial class frm_Method : Form
    {
        public frm_Method()
        {
            InitializeComponent();
        }
        int[] arr0711 = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arr0711_str = new string[8] {"mother張","emma","迪克蕭","J40","Candy","Cindy","Coconut","MotherFacker"};
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("請輸入數值噢");
            }
            else
            {
                int f =int.Parse (txtInput.Text);
                string result = "";
                if (f % 2 == 0)
                {
                    result = "偶數";
                }
                else
                {
                    result = "奇數";
                }
                txtResult.Text = "輸入的數" +f+ "為"+result;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = "結果";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + "\n最大值為" + arr0711.Max() + "\n最小值為" + arr0711.Min();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int evenCount = 0;
            int oddCount = 0;
            foreach(int h in arr0711)
            {
                if (h %2== 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            txtResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + "\n奇數共" + oddCount + "\n偶數共" + evenCount;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string result = arr0711_str.Aggregate((max, next) => max.Length < next.Length ? next : max);
            txtResult.Text = "陣列arr0711_Str[mother張,emma,迪克蕭,J40,Candy,Cindy,Coconut,MotherFacker]"+"\n最長的名字是" + result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c_count = 0;
            foreach (string h in arr0711_str){
                if(h.Contains("C") | h.Contains("c"))
                {
                    c_count++;
                }
                else
                {
                    continue;
                }
            }
            txtResult.Text = "陣列arr0711_Str[mother張,emma,迪克蕭,J40,Candy,Cindy,Coconut,MotherFacker]" + "\n有C及c的名字共有" + c_count + "個";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sum=arr0711.Aggregate((total,next) => total+next);
            txtResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + "\n加總為" + sum;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int Max = arr0711.Aggregate((max, next) => max < next ?next:max);
            txtResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + "\n最大值為" + Max;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int Min = arr0711.Aggregate((min, next) => min > next ? next : min);
            txtResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + "\n最小值為" + Min;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            int[,] arr_Square = new int[10, 10] { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } }; //建立一個二微陣列
            for (int i = 0; i < 10; i++)
            {
                for (int g = 0; g < 10; g++)
                {
                    txtResult.Text += arr_Square.GetValue(i, g) + " ";

                }
                txtResult.Text += "\n";

            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            int[,] arr_Square = new int[10, 10] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 } , { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } }; //建立一個二微陣列
            for (int i = 0; i < 10; i++)
            {
                for (int g = 0; g < 10; g++)
                {
                    txtResult.Text += arr_Square.GetValue(i, g) + " ";

                }
                txtResult.Text += "\n";

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[][] arr_Square = new int[10][]; //建立二維振列
            for(int i = 0; i < 10; i++)
            { 
                
                if (i % 2 == 0)
                {
                    arr_Square[i] = new int[10] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };
                }
                else
                {
                    arr_Square[i] = new int[10] { 0, 1, 0, 1, 0, 1, 0, 1, 0,1 };
                }

            }
            txtResult.Text = "";
            for (int i = 0; i < 10; i++) //輸出陣列
            {
                for (int g = 0; g < 10; g++)
                {
                    txtResult.Text += arr_Square[i][g] + " ";

                }
                txtResult.Text += "\n";

            }

        }

        void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void button10_Click(object sender, EventArgs e)
        { //todo 需要再看書瞭解一下捏
            txtResult.Text = "";
            int n1 = 100;
            int n2 = 200;
            string result1 = "換位前n1=" + n1 + ",n2=" + n2;
            Swap(ref n1, ref n2);
            string result2= "\n換位前n1=" + n1 + ",n2=" + n2;
            txtResult.Text = result1 + result2;
            
        }
    }
}
