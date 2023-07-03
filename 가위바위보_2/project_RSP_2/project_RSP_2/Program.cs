using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace project_RSP_2
{
    class Program
    {
        enum Game { 가위 =1,바위,보}
        static void Play()
        {
            //선언부
            int player, computer;
            Random random = new Random();

            //출력부 + 입력부
            while (true)
            {
                computer = random.Next(1, 3 + 1);                                
                WriteLine("\n가위바위보 게임을 시작합니다. \n\n1.가위\n2.바위\n3.보자기 \n숫자를 입력하세요.");
                if (!int.TryParse(ReadLine(), out player))
                {
                    WriteLine("잘못입력했습니다. 1~3숫자를 입력해주세요.");
                }

                //연산부(숫자밖 범위 잘못됐습니다, 숫자범위)  
                WriteLine($"플레이어는 :{(Game)player} \n컴 퓨 터는 :{(Game)computer}");                
                if (!(player >= 1 && player <= 3))
                {
                    WriteLine("잘못된 숫자범위입니다.");
                }
                else
                {
                    if ((player == 1 && computer == 3) || (player == 2 && computer == 1) || (player == 3 && computer == 2))
                    {
                        WriteLine("플레이어가 이겼습니다.");
                    }
                    else if (player == computer)
                    {
                        WriteLine("비겼습니다");
                    }
                    else
                    {
                        WriteLine("플레이어가 졌습니다");
                    }                    
                }
            }

        }

        static void Main(string[] args)
        {
            Play();
        }
    }
}
