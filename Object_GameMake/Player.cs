using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object_GameMake
{
    
    public enum Job {전사 = 1, 도둑, 마법사, 음유시인}
    internal abstract class Player
    {

        protected Job job;
        public Job Job { get { return job; } }

        protected int str;
        public int Str { get { return str; } }
        //      힘스텟
        protected int dex;
        public int Dex { get { return dex; } }
        //      민첩스텟
        protected int intel;
        public int Intel { get { return intel; } }
        //      지능스텟
        protected int charm;
        public int Charm { get { return charm; } }
        //      매력스텟
        
        protected int curHp;
        public int CurHp { get { return curHp; } }
        //      현재 체력

        protected int maxHp;
        public int MaxHp { get { return maxHp; } }
        //      최대 체력



        public string[] inventory = new string[6];

        public Player()
        {
            
            this.str = 5;
            this.dex = 5;
            this.intel = 5;
            this.charm = 5;
            this.curHp = 3;
            this.maxHp = 3;

        }
    }
    class Warrior : Player
    {

        public Warrior()
        {
            
            this.job = Job.전사;
            this.str = 15;
            this.dex = 10;
            this.intel = base.intel;
            this.charm = base.charm;
            this.curHp = 7;
            this.maxHp= 7;
            
            string[] inventory = base.inventory;
        }

    }
    class Thief : Player
    {

        public Thief()
        {
            this.job = (Job)2;
            this.str = base.str;
            this.dex = 15;
            this.intel = 10;
            this.charm = base.charm;
            this.curHp = 5;
            this.maxHp = 5;
            
            string[] inventory = base.inventory; ;
        }
    }
    class Mage : Player
    {

        public Mage()
        {
            this.job = (Job)3;
            this.str = base.str;
            this.dex = base.str;
            this.intel = 15;
            this.charm = 10;
            this.curHp = base.curHp;
            this.maxHp = base.maxHp;
            
            string[] inventory = base.inventory;
        }
    }
    class Bard : Player
    {

        public Bard()
        {
            this.job = (Job)4;
            this.str = base.str;
            this.dex = base.dex;
            this.intel = 10;
            this.charm = 15;
            this.curHp = 5;
            this.maxHp = 5;
            
            string[] inventory = base.inventory;
        }
    }


}

