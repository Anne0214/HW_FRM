using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_FRM
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
            labNow.Text = DateTime.Now.ToString("HH:mm:ss");  //顯示當前時間

            //判斷是否到達已設定鬧鐘的時間
            if (switchBox.Checked)
            { 
                //當前是否有設定鬧鐘
                if (alarmObject.Hour == DateTime.Now.Hour)
                { //與設定的鬧鐘小時相同
                    if (alarmObject.Minute == DateTime.Now.Minute)
                    {//與設定的鬧鐘分鐘相同
                        if (alarmObject.Second == DateTime.Now.Second)
                        {//與設定的鬧鐘秒數相同，則當作已到達時間
                            switchBox.Checked = false;
                            System.Media.SoundPlayer sp = new SoundPlayer();
                            sp.SoundLocation = @"..\13463.WAV";
                            sp.Play();
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
            if(switchBox.Checked) //有設定鬧鐘
            {
                try
                {
                    txtAlarm.Enabled = false; //不可再修改時間
                    string temp = txtAlarm.Text;

                    alarmObject = DateTime.ParseExact(temp, "HH:mm:ss", null);//取得用戶輸入的時間，並轉換成datetime存取
                    DateTime now = DateTime.Now;
                    int timeCount = (int)(alarmObject - now).TotalMinutes; //相距分鐘數
                    if (timeCount > 1) //倘若距今時間超過1分鐘，則跳彈窗顯示還有多久會響鈴
                    {
                        MessageBox.Show($"幫你設好鬧鐘了，{timeCount}分鐘後會響鈴");
                    }else if (timeCount < 0) //如果鬧鐘時間設定在明天
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
                catch (Exception)
                {
                    MessageBox.Show("發生不明錯誤(･8･)請稍後再試");
                    txtAlarm.Enabled = true;
                    switchBox.Checked = false;
                    txtAlarm.Text = "時:分:秒";
                    txtAlarm.Focus();
                }


            }
            else
            {
                txtAlarm.Enabled = true; //沒有設定鬧鐘的狀況，鬧鐘時間可編輯
                
            }
        }

        private void frm_Alarm_Load(object sender, EventArgs e)
        { //當視窗在Load時左上角就要開始顯示當前時間了
            labNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
