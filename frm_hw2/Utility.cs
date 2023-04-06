using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace frm_hw2
{
    
        public struct Student
        {
            public string Name;
            public int scoreChi;
            public int scoreMath;
            public int scoreEng;
            
        }
    public struct GuessGame
    {
        
        static public int answer { get; set; }
        static public int max { get; set; }
        static public int min { get; set; }
        static public string instruction { get; set; }
        

        public void NewGame()
        {
            Random rd= new Random();
            answer = rd.Next(1,100);
            max = 100;
            min = 1;
            instruction= "來玩猜數字! 答案是1~100之間的數字"; 

        }
        public void Result(int input) {
            //todo其實只要結果有string就好，但我想寫寫看out。應該有更好的寫法，再看看

            
            if (input == answer)
            {
                
                instruction = "答對了! 答案就是" + answer;
            }
            else if (input < answer)
            {
                instruction = "太小了! 答案在" + input + "-"+max+"之間";
                min = input;
            }
            else
            {
                instruction = "太大了! 答案在" + min + "-" +input+"之間";
                max = input;
            }

            

        }
        

     }

        

    
}
