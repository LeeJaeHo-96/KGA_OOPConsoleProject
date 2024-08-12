using static Object_GameMake.Program;

namespace Object_GameMake
{
    internal class Program
    {
        public enum ItemType
        {
            장비아이템, 기타, 골드환산아이템
        }
        public enum ItemGrade
        {
            Epic, Rare, Common
        }
        public struct Item
        {
            public string itemName;
            public ItemType type;
            public ItemGrade grade;
            public int itemPrice;
        }

        public enum GameState
        {
            Title, Tutorial, Menu, MonsterHunt, ManHunt, Inventory, GameOver
        }
        static void Main(string[] args)
        {
            Graphics graphics = new Graphics();
            GameState state = GameState.Title;
            graphics.Intro();
            
            if (state == GameState.Title)
            {
                graphics.menu();
                Game.Input();
            }
            else if( state == GameState.Tutorial)
            {
                Console.WriteLine("튜토리얼");
            }
        }
        
    }
    public static class Game
    {
        public static void Input()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            GameState state;
            switch (key)
            {
                case ConsoleKey.D1:
                    state = GameState.Tutorial;
                    break;
                case ConsoleKey.D2:
                    state = GameState.MonsterHunt;
                    break;
                case ConsoleKey.D3:
                    state = GameState.ManHunt;
                    break;
                case ConsoleKey.D4:
                    state = GameState.Inventory;
                    break;
                case ConsoleKey.D5:
                    state = GameState.GameOver;
                    break;

                
            }
        }
    }
}
