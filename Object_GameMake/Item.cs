using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
//using static Object_GameMake.Program;

namespace Object_GameMake
{
    public enum ItemType
    {
        retain, expendables
    }
    

    internal class Item
    {
        public string itemName;
        public ItemType type;
        public int str;
        public int dex;
        public int intel;
        public int charm;
        public int curHp;
        public int maxHp;
        public void SmellingSalt()
        {
            string itemName = "스멜링 솔트";
            ItemType type = ItemType.retain;
            int str = 3;
            int dex = 3;
            Console.WriteLine();

        }

        public void PhilosophersStone()
        {
            string itemName = "현자의 돌";
            ItemType type = ItemType.retain;
            int intel = 3;
            int charm = 3;
            Console.WriteLine();

        }

        public void steroid()
        {
            string itemName = "스테로이드";
            ItemType type = ItemType.expendables;
            int str = 4;
            int dex = 4;

            Console.WriteLine();

        }

        public void SmartPotion()
        {
            string itemName = "똑똑해지는 물약";
            ItemType type = ItemType.expendables;
            int intel = 4;
            int charm = 4;

            Console.WriteLine();

        }
        public void figthBook()
        {
            string itemName = "싸움잘해지는법 책";
            ItemType itemType = ItemType.retain;
            int maxHp = 1;
        }

        public void HpPotion()
        {
            string itemName = "HP 포션";
            ItemType itemType = ItemType.expendables;
            int curHp = 2;
        }
    }
}
