using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_GameMake
{
    internal class Graphics
    {
        public void Intro()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    ■      ■   ■     ■    ■     ■   ■■■■■■  ■■■■■      ■■■  ");
            Console.WriteLine("    ■      ■   ■     ■    ■■   ■       ■■      ■              ■   ■ ");
            Console.WriteLine("    ■■■■■   ■     ■    ■ ■  ■       ■■      ■■■■■      ■■■  ");
            Console.WriteLine("    ■      ■   ■     ■    ■   ■■       ■■      ■              ■   ■ ");
            Console.WriteLine("    ■      ■    ■■■■    ■     ■       ■■      ■■■■■      ■    ■ ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                        Press any Key");
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();

        }

        public void menu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                   할 행동을 선택해주세요.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    (1. [권장] 전투 설명을 듣는다 [권장])");
            Console.ResetColor();
            Console.WriteLine("    (2. 몬스터 사냥)");
            Console.WriteLine("    (3. 결투장)");
            Console.WriteLine("    (4. 인벤토리 확인)");
            Console.WriteLine("    (5. 로그아웃)");
            ConsoleKey key = Console.ReadKey(true).Key;
            
            {

            }
        }

    }
}
