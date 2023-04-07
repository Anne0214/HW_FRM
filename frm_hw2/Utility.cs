using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_hw2
{
    
        public struct Student
        {
            public string Name;
            public int scoreChi;
            public int scoreMath;
            public int scoreEng;
            
        }
    static public  class GuessGame //靜態類別，這樣才能讓frm_Guess兩個視窗去共同取用
    {
        //靜態類別下的成員都是靜態的
        static public int answer { get; set; }
        static public int max { get; set; }
        static public int min { get; set ; } //todo 可以嘗試看看改set的寫法

        

        static public void  NewGame() //遊戲開始或重開時會叫的方法
        {
            Random rd = new Random();
            int value = rd.Next(1,100);
            answer = value;
            max = 100;
            min = 1;
            

        }
        static public string Result(int input,out bool victory) { //判斷獲勝與否的方法。input是作答內容，victory是用來判斷的指標。這邊也可以string在子視窗做處理
           

            
            if (input == answer)
            {
                victory = true;
                int value = answer;
                NewGame();
                return "答對了! 答案就是" + value;
            }
            else if (input < answer)
            {
                min = input;
                victory = false;
                return "太小了! 答案在" + input + "-"+max+"之間";
                
            }
            else
            {
                max = input;
                victory = false;
                return  "太大了! 答案在" + min + "-" +input+"之間";
                
            }

            

        }
        

     }

        

    
}
