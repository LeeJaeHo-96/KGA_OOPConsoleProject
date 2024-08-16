using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Object_GameMake.Program;

namespace Object_GameMake
{
    
    internal class GamePlay
    {
        Scene scene = new Scene();
      
        public void Run()
        {
            while (true)
            {
                scene.Menu();
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1)
                {
                    scene.Tutorial();
                    
                    
                }
                else if (key == ConsoleKey.D2)
                {
                    scene.Scene_Select();
                    scene.Scene_InGame();

                }
                else if (key == ConsoleKey.D3)
                {
                    scene.Logout();
                    break;
                }
               // else if (key == ConsoleKey.D3)  미개발
               // {
               //     //scene.Scene_Inventorty();
               // }
            }
        }
    }
}

