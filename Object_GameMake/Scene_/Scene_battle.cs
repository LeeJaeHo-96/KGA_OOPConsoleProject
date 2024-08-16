using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_GameMake
{
    internal partial class Scene
    {
        public void Battle_Dog()
        {
            monsterHp = dog.MaxHp;
            playerHp = stat.Cur_Hp;

            while (monsterHp > 0)
            {
                if (playerHp == 0)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" 다행히 몬스터가 매우 약해보입니다.");
                Console.WriteLine();

                monsterS = dog.Name;
                
                dog.curHp = monsterHp;
                stat.Cur_Hp = playerHp;
                playerHp = stat.Cur_Hp;


                Console.WriteLine($"몬스터 이름 : {dog.Name}");
                Console.WriteLine($"힘 : {dog.Str}");
                Console.WriteLine($"민첩성 : {dog.Dex}");
                Console.WriteLine($"지능 : {dog.Intel}");
                Console.WriteLine($"체력 : {dog.curHp}    나의 체력 : {stat.Cur_Hp}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. 정면으로 공격한다.");
                Console.WriteLine("2. 천천히 접근하여 뒤를 노린다.");
                Console.WriteLine("3. 마비 마법을 시도한다.");
                Console.WriteLine("4. 도망친다.");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D1)
                {
                    if (stat.Sclass > 10)
                    {
                        Str_Win();
                    }
                    else
                    {
                        Str_lose();

                    }
                }
                else if (key == ConsoleKey.D2)
                {
                    if (stat.Dclass > 10)
                    {
                        Dex_Win();
                    }
                    else
                    {
                        Dex_lose();
                    }
                }
                else if (key == ConsoleKey.D3)
                {
                    if (stat.Iclass > 10)
                    {
                        Int_Win();
                    }
                    else
                    {
                        Int_lose();
                    }
                }
                else if (key == ConsoleKey.D4)
                {
                    Random run = new Random();
                    int runRan = run.Next(6);
                    if (runRan == 0 || runRan == 1)
                    {
                        Run_SSuc();
                    }
                    else if (runRan == 2 || runRan == 3 || runRan ==4)
                    {
                        Run_Suc();
                    }
                    else
                    {
                        Run_Fail();
                    }
                }
            }
            if (playerHp < 1)
            {
                Logout();
            }
            

        }
        public void Battle_Zombie()
        {
            monsterHp = zombie.MaxHp;
            playerHp = stat.Cur_Hp;

            while (monsterHp > 0)
            {
                if (playerHp == 0)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" 조금 위협적인 몬스터를 마주했습니다..");
                Console.WriteLine();

                monsterS = zombie.Name;
                
                zombie.curHp = monsterHp;
                stat.Cur_Hp = playerHp;
                playerHp = stat.Cur_Hp;


                Console.WriteLine($"몬스터 이름 : {zombie.Name}");
                Console.WriteLine($"힘 : {zombie.Str}");
                Console.WriteLine($"민첩성 : {zombie.Dex}");
                Console.WriteLine($"지능 : {zombie.Intel}");
                Console.WriteLine($"체력 : {zombie.curHp}    나의 체력 : {stat.Cur_Hp}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. 정면으로 공격한다.");
                Console.WriteLine("2. 천천히 접근하여 뒤를 노린다.");
                Console.WriteLine("3. 마비 마법을 시도한다.");
                Console.WriteLine("4. 도망친다.");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D1)
                {
                    if (stat.Sclass > 10)
                    {
                        Str_Win();
                    }
                    else
                    {
                        Str_lose();

                    }
                }
                else if (key == ConsoleKey.D2)
                {
                    if (stat.Dclass > 10)
                    {
                        Dex_Win();
                    }
                    else
                    {
                        Dex_lose();
                    }
                }
                else if (key == ConsoleKey.D3)
                {
                    if (stat.Iclass > 10)
                    {
                        Int_Win();
                    }
                    else
                    {
                        Int_lose();
                    }
                }
                else if (key == ConsoleKey.D4)
                {
                    Random run = new Random();
                    int runRan = run.Next(6);
                    if (runRan == 0 || runRan == 1)
                    {
                        Run_SSuc();
                    }
                    else if (runRan == 2 || runRan == 3 || runRan == 4)
                    {
                        Run_Suc();
                    }
                    else
                    {
                        Run_Fail();
                    }
                }
            }
            if (playerHp < 1)
            {
                Logout();
            }
            

        }
        public void Battle_Orc()
        {
            monsterHp = orc.MaxHp;
            playerHp = stat.Cur_Hp;

            while (monsterHp > 0)
            {
                if (playerHp == 0)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("당신은 운이 없는 것 같습니다..");
                Console.WriteLine();

                monsterS = orc.Name;
                
                orc.curHp = monsterHp;
                stat.Cur_Hp = playerHp;
                playerHp = stat.Cur_Hp;


                Console.WriteLine($"몬스터 이름 : {orc.Name}");
                Console.WriteLine($"힘 : {orc.Str}");
                Console.WriteLine($"민첩성 : {orc.Dex}");
                Console.WriteLine($"지능 : {orc.Intel}");
                Console.WriteLine($"체력 : {orc.curHp}    나의 체력 : {stat.Cur_Hp}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. 정면으로 공격한다.");
                Console.WriteLine("2. 천천히 접근하여 뒤를 노린다.");
                Console.WriteLine("3. 마비 마법을 시도한다.");
                Console.WriteLine("4. 도망친다.");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D1)
                {
                    if (stat.Sclass > 10)
                    {
                        Str_Win();
                    }
                    else
                    {
                        Str_lose();

                    }
                }
                else if (key == ConsoleKey.D2)
                {
                    if (stat.Dclass > 10)
                    {
                        Dex_Win();
                    }
                    else
                    {
                        Dex_lose();
                    }
                }
                else if (key == ConsoleKey.D3)
                {
                    if (stat.Iclass > 10)
                    {
                        Int_Win();
                    }
                    else
                    {
                        Int_lose();
                    }
                }
                else if (key == ConsoleKey.D4)
                {
                    Random run = new Random();
                    int runRan = run.Next(5);
                    if (runRan == 0 || runRan == 1)
                    {
                        Run_SSuc();
                    }
                    else if (runRan == 2 || runRan == 3 || runRan == 4)
                    {
                        Run_Suc();
                    }
                    else
                    {
                        Run_Fail();
                    }
                }
            }
            if (playerHp < 1)
            {
                Logout();
            }
            
               

        }
        public void Battle_Ogre()
        {
            monsterHp = ogre.MaxHp;
            playerHp = stat.Cur_Hp;

            while (monsterHp > 0)
            {
                if (playerHp == 0)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("당신은 마침내 모든 악의 근원이자 오크들의 수장인 오우거를 마주쳤습니다..");
                Console.WriteLine("당신은 목숨을 걸고 마지막 전투에 임합니다..");
                Console.WriteLine();

                monsterS = ogre.Name;

                ogre.curHp = monsterHp;
                stat.Cur_Hp = playerHp;
                playerHp = stat.Cur_Hp;


                Console.WriteLine($"몬스터 이름 : {ogre.Name}");
                Console.WriteLine($"힘 : {ogre.Str}");
                Console.WriteLine($"민첩성 : {ogre.Dex}");
                Console.WriteLine($"지능 : {ogre.Intel}");
                Console.WriteLine($"체력 : {ogre.curHp}    나의 체력 : {stat.Cur_Hp}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. 정면으로 공격한다.");
                Console.WriteLine("2. 천천히 접근하여 뒤를 노린다.");
                Console.WriteLine("3. 마비 마법을 시도한다.");
                Console.WriteLine("4. 도망친다.");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D1)
                {
                    if (stat.Sclass > 10)
                    {
                        Str_Win();
                    }
                    else
                    {
                        Str_lose();

                    }
                }
                else if (key == ConsoleKey.D2)
                {
                    if (stat.Dclass > 10)
                    {
                        Dex_Win();
                    }
                    else
                    {
                        Dex_lose();
                    }
                }
                else if (key == ConsoleKey.D3)
                {
                    if (stat.Iclass > 10)
                    {
                        Int_Win();
                    }
                    else
                    {
                        Int_lose();
                    }
                }
                else if (key == ConsoleKey.D4)
                {
                    
                        Run_Fail();
                    
                }
            }
            if (playerHp < 1)
            {
                Logout();
            }
            else
                Scene_Ending();

        }
    }
}
