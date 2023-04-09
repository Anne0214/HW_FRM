using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_hw2
{
    public partial class frm_Alarm : Form
    {
        public frm_Alarm()
        {
            InitializeComponent();
        }
        DateTime alarmObject;


        private void timer1_Tick(object sender, EventArgs e)
        {
            labNow.Text = DateTime.Now.ToString("HH:mm:ss");
            if (switchBox.Checked)
            { 
                
                if (alarmObject.Hour == DateTime.Now.Hour)
                {
                    if (alarmObject.Minute == DateTime.Now.Minute)
                    {
                        if (alarmObject.Second == DateTime.Now.Second)
                        {
                            switchBox.Checked = false;
                            MessageBox.Show("到時間了");
                            txtAlarm.Enabled = true;
                            txtAlarm.Text = "時:分:秒";
                        }

                    }
                }

            }
        }
        private void switchBox_CheckedChanged(object sender, EventArgs e)
        {
            if(switchBox.Checked)
            { //取得用戶輸入的時間，並轉換成datetime存取
                //倘若距今時間超過1分鐘，則跳彈窗顯示還有多久會響鈴
                //沒有則無動作
                txtAlarm.Enabled = false;
                string temp = txtAlarm.Text;
                try
                {
                    alarmObject = DateTime.ParseExact(temp, "HH:mm:ss", null);


                    DateTime now = DateTime.Now;


                    int timeCount = (int)(alarmObject - now).TotalMinutes; //相距分鐘數

                    if (timeCount > 1)
                    {
                        MessageBox.Show($"幫你設好鬧鐘了，{timeCount}分鐘後會響鈴");
                    }else if (timeCount < 0)
                    {
                        
                        MessageBox.Show($"幫你設好鬧鐘了，會在明天的{temp}響鈴");
                    }
                }
                catch (ArgumentNullException) { 
                    MessageBox.Show("請依照「時:分:秒」的格式輸入，且都必須輸入二位數");
                    txtAlarm.Enabled = true;
                    switchBox.Checked = false;
                    txtAlarm.Text = "時:分:秒";
                    txtAlarm.Focus();
                }
                catch (FormatException)
                {
                    MessageBox.Show("請依照「時:分:秒」的格式輸入，且都必須輸入二位數"); 
                    txtAlarm.Enabled = true;
                    switchBox.Checked = false;
                    txtAlarm.Text = "時:分:秒";
                    txtAlarm.Focus();
                }
                
            }
            else
            {
                txtAlarm.Enabled = true;
                
            }
        }

        private void frm_Alarm_Load(object sender, EventArgs e)
        {
            labNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
