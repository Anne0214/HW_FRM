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
    static public  class GuessGame
    {
        
        static public int answer { get; set; }
        static public int max { get; set; }
        static public int min { get; set ; } //todo 可以嘗試看看改set的寫法

        

        static public void  NewGame()
        {
            Random rd = new Random();
            int value = rd.Next(1,100);
            answer = value;
            max = 100;
            min = 1;
            

        }
        static public string Result(int input,out bool victory) {
           

            
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
