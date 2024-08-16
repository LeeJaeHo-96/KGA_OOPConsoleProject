using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object_GameMake
{

    
    internal abstract class Monster
    {

        protected string name;
        public string Name { get { return name; } }

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

        public int curHp;
        public int CurHp { get { return curHp; } }
        //      현재 체력

        protected int maxHp;
        public int MaxHp { get { return maxHp; } }
        //      최대 체력



        

        public Monster()
        {
            this.name = "몬스터";
            this.str = 1;
            this.dex = 1;
            this.intel = 1;
            this.charm = 1;
            this.curHp = 1;
            this.maxHp = 1;

        }
    }
    class Dog : Monster
    {

        public Dog()
        {

            this.name = "들개";
            this.str = 5;
            this.dex = 5;
            this.intel = base.intel;
            this.charm = base.charm;
            this.curHp = base.curHp;
            this.maxHp = base.maxHp;

        }

    }
    class Zombie : Monster
    {

        public Zombie()
        {
            this.name = "좀비";
            this.str = 10;
            this.dex = base.dex;
            this.intel = base.intel;
            this.charm = base.charm;
            this.curHp = 2;
            this.maxHp = 2;

        }
    }
    class Orc : Monster
    {

        public Orc()
        {
            this.name = "오크";
            this.str = 15;
            this.dex = 10;
            this.intel = 5;
            this.charm = base.charm;
            this.curHp = 4;
            this.maxHp = 4;

        }
    }
    class Ogre : Monster
    {

        public Ogre()
        {
            this.name = "오우거 - 오크들의 우두머리";
            this.str = 20;
            this.dex = 20;
            this.intel = 20;
            this.charm = base.charm;
            this.curHp = 10;
            this.maxHp = 10;

        }
    }


}

