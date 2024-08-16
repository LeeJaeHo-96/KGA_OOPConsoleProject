using static Object_GameMake.Program;
using static System.Formats.Asn1.AsnWriter;

namespace Object_GameMake
{
    
    internal class Program
    {
        public enum GameState
        {
            Title, Tutorial, Menu, SelectJob, Inventory, GameOver
        }
        



        static void Main(string[] args)
        {
            
            Scene scene = new Scene();
            GamePlay game = new GamePlay();
            
            scene.Intro();
            
            game.Run();

            
        }
        
    }
    
}
