using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;

namespace Object_GameMake
{
   

    internal partial class Scene
    {
        public void Scene_InGame()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"당신의 직업은 {stat.Pclass}입니다.");
            Console.WriteLine($"힘 : {stat.Sclass}");
            Console.WriteLine($"민첩 : {stat.Dclass}");
            Console.WriteLine($"지능 : {stat.Iclass}");
            Console.WriteLine($"매력 : {stat.Cclass}");
            Console.WriteLine($"체력 : {stat.Cur_Hp}/{stat.Max_Hp}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("            PRESS ANY KEY");
            Console.ReadKey();
            if (stat.Pclass == Job.전사)
            {
                Console.Clear();
                Scene_FirstWarrior();
            }
            else if (stat.Pclass == Job.도둑)
            {
                Console.Clear();
                Scene_FirstThief();
            }
            else if (stat.Pclass == Job.마법사)
            {
                Console.Clear();
                Scene_FirstMage();
            }
            else if (stat.Pclass == Job.음유시인)
            {
                Console.Clear();
                Scene_FirstBard();
            }
            else
            {
                Console.Clear();
                Scene_FirstWarrior();
            }
            
            Scene_FindPeople();
            Scene_FindMonster();
            Scene_Town();
            Scene_FindPeople2();
            Scene_FindMonster2();
            Scene_Town2();
            Battle_Ogre();
        }
        struct StatClass
        {
           public Job Pclass;
           public int Sclass;
           public int Dclass;
           public int Iclass;
           public int Cclass;
           public int Cur_Hp;
           public int Max_Hp;
        }
        StatClass stat;
        int choice;
        

        Warrior warrior = new Warrior();
        Thief thief = new Thief();
        Mage mage = new Mage();
        Bard bard = new Bard();

        string monsterS;
        int monsterHp;
        int playerHp;

        Dog dog = new Dog();
        Zombie zombie = new Zombie();
        Orc orc = new Orc();
        Ogre ogre = new Ogre();

        int step = 0;
        
        public enum GameState
        {
            Title, Tutorial, Menu, SelectJob, Inventory, GameOver
        }
        
        
        Program program = new Program();
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

        public void Menu()
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
            Console.WriteLine("    (1. [권장] 게임 설명을 듣는다 [권장])");
            Console.ResetColor();
            Console.WriteLine("    (2. 모험 떠나기)");
            Console.WriteLine("    (3. 로그아웃)");
            Console.WriteLine();
          
        }
        public void Tutorial()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("      HUNTER 는 TextRPG 게임입니다.    ");
            Console.WriteLine("     상황에 따라 적절한 선택지를 입력하면   ");
            Console.WriteLine("     계속 진행할 수 있습니다.    ");
            Console.WriteLine("     특정 이벤트에서 잘못된 선택지를 선택 할 경우, 사망합니다.   ");
            Console.WriteLine("     당신의 행운을 빕니다!   ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                    PRESS ANY KEY");

            Console.ReadKey();

        }

        public dynamic Scene_Select()
        {
            StatClass warriorStat;
            warriorStat.Pclass = warrior.Job;
            warriorStat.Sclass = warrior.Str;
            warriorStat.Dclass = warrior.Dex;
            warriorStat.Iclass = warrior.Intel;
            warriorStat.Cclass = warrior.Charm;
            warriorStat.Cur_Hp = warrior.CurHp;
            warriorStat.Max_Hp = warrior.MaxHp;

            StatClass thiefStat;
            thiefStat.Pclass = thief.Job;
            thiefStat.Sclass = thief.Str;
            thiefStat.Dclass = thief.Dex;
            thiefStat.Iclass = thief.Intel;
            thiefStat.Cclass = thief.Charm;
            thiefStat.Cur_Hp = thief.CurHp;
            thiefStat.Max_Hp = thief.MaxHp;

            StatClass mageStat;
            mageStat.Pclass = mage.Job;
            mageStat.Sclass = mage.Str;
            mageStat.Dclass = mage.Dex;
            mageStat.Iclass = mage.Intel;
            mageStat.Cclass = mage.Charm;
            mageStat.Cur_Hp = mage.CurHp;
            mageStat.Max_Hp = mage.MaxHp;

            StatClass bardStat;
            bardStat.Pclass = bard.Job;
            bardStat.Sclass = bard.Str;
            bardStat.Dclass = bard.Dex;
            bardStat.Iclass = bard.Intel;
            bardStat.Cclass = bard.Charm;
            bardStat.Cur_Hp = bard.CurHp;
            bardStat.Max_Hp = bard.MaxHp;




            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("      직업을 골라주세요.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     1. 전사");
            Console.WriteLine("     2. 도둑");
            Console.WriteLine("     3. 마법사");
            Console.WriteLine("     4. 음유시인");
            Console.WriteLine();
            
            ConsoleKey key = Console.ReadKey(true).Key;
            

            

            if (key == ConsoleKey.D1)
            {
                //전사 선택
                Console.WriteLine("전사를 선택하셨습니다.");
                return stat = warriorStat;
            }
            else if (key == ConsoleKey.D2)
            {
                //도적 선택
                Console.WriteLine("도둑을 선택하셨습니다.");
                return stat = thiefStat;
            }
            else if (key == ConsoleKey.D3)
            {
                //마법사 선택
                Console.WriteLine("마법사를 선택하셨습니다.");
                return stat = mageStat;
            }
            else if (key == ConsoleKey.D4)
            {
                // 음유시인 선택
                Console.WriteLine("음유시인을 선택하셨습니다.");
                return stat = bardStat;
            }
            else
            {
                Console.WriteLine("직업을 다시 선택해 주세요.");
                return Scene_Select();
            }
        }

        
        public void Scene_FirstWarrior()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("당신은 망해버린 왕국을 떠나 왕국을 멸망시킨 악의 근원 오우거를");
            Console.WriteLine("찾아 떠나는 중입니다.");
            Console.WriteLine("당신은 힘이 강하고 체력이 높아 육탄전에 유리합니다.");
            Console.WriteLine("이제 당신의 모험을 시작하겠습니다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            
            
        }

        public void Scene_FirstThief()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("당신은 망해버린 왕국을 떠나 왕국을 멸망시킨 악의 근원 오우거를");
            Console.WriteLine("찾아 떠나는 중입니다.");
            Console.WriteLine("당신은 민첩성이 좋아 속도를 활용한 움직임에 유리합니다.");
            Console.WriteLine("이제 당신의 모험을 시작하겠습니다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            
            
        }

        public void Scene_FirstMage()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("당신은 망해버린 왕국을 떠나 왕국을 멸망시킨 악의 근원 오우거를");
            Console.WriteLine("찾아 떠나는 중입니다.");
            Console.WriteLine("당신은 지능이 높아 여러 문제들을 해결하기 유리합니다.");
            Console.WriteLine("이제 당신의 모험을 시작하겠습니다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            
            
        }

        public void Scene_FirstBard()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("당신은 망해버린 왕국을 떠나 왕국을 멸망시킨 악의 근원 오우거를");
            Console.WriteLine("찾아 떠나는 중입니다.");
            Console.WriteLine("당신은 상당히 매력적이라 다른 사람들을 이용, 포섭하기 유리합니다.");
            Console.WriteLine("이제 당신의 모험을 시작하겠습니다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            
            
        }
        public void Scene_FindPeople()
        {
            step = 1;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("앞에 농부가 보입니다.");
            Console.WriteLine("행동을 선택해주세요.");
            Console.WriteLine();
            Console.WriteLine();
            if (stat.Cclass >= 10)
            Console.WriteLine("1. 말을 건다.");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("1. 말을 건다.");
                Console.ResetColor();
            }
            if (stat.Sclass >= 10)
            Console.WriteLine("2. 주먹으로 때린다.");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("2. 주먹으로 때린다.");
                Console.ResetColor();
            }
            Console.WriteLine("3. 무시하고 가던 길을 간다.");

            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D1)
            {
                if (stat.Cclass < 10)
                {
                    if (step == 1)
                    {
                        Chilly();
                    }
                    else if (step == 2)
                    {
                        Chilly2();
                    }
                    else
                    {
                        Help();
                    }
                }
            }
            else if (key == ConsoleKey.D2)
            {
                if (stat.Sclass < 10)
                {
                    if (step == 1)
                    {
                        Beaten();
                    }
                    else if(step == 2)
                            {
                            Beaten2();
                        }
                }
                else
                {
                    if (step == 1)
                    {
                        Beat();
                    }
                    else if (step == 2)
                    {
                        Beat2();
                    }
                }
            }
            else if (key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("곤경에 처해보이는 사람을 무시하고");
                Console.WriteLine("가던길을 마저 갑니다.");

                Console.ReadKey();
               
            }
            

        }
        public void Scene_FindPeople2()
        {
            step = 2;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("앞에 부유해보이는 상인이 보입니다.");
            Console.WriteLine("행동을 선택해주세요.");
            Console.WriteLine();
            Console.WriteLine();
            if (stat.Cclass >= 10)
                Console.WriteLine("1. 말을 건다.");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("1. 말을 건다.");
                Console.ResetColor();
            }
            if (stat.Sclass >= 10)
                Console.WriteLine("2. 주먹으로 때린다.");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("2. 주먹으로 때린다.");
                Console.ResetColor();
            }
            Console.WriteLine("3. 무시하고 가던 길을 간다.");

            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D1)
            {
                if (stat.Cclass < 10)
                {
                    if (step == 1)
                    {
                        Chilly();
                    }
                    else if (step == 2)
                    {
                        Chilly2();
                    }
                    else
                    {
                        Help();
                    }
                }
            }
            else if (key == ConsoleKey.D2)
            {
                if (stat.Sclass < 10)
                {
                    if (step == 1)
                    {
                        Beaten();
                    }
                    else if (step == 2)
                    {
                        Beaten2();
                    }
                }
                else
                {
                    if (step == 1)
                    {
                        Beat();
                    }
                    else if (step == 2)
                    {
                        Beat2();
                    }
                }
            }
            else if (key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("곤경에 처해보이는 사람을 무시하고");
                Console.WriteLine("가던길을 마저 갑니다.");

                Console.ReadKey();
                
            }
        }
        public void Scene_FindMonster()
        {
            Console.Clear();
            Random random = new Random();
            int monsterSpawn = random.Next(4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 당신은 몬스터를 마주했습니다.");
            Console.ReadKey();
            if (monsterSpawn == 0 || monsterSpawn == 1)
            {
                Battle_Dog();
            }
            else if (monsterSpawn == 2)
            {
                Battle_Zombie();
            }
            else if (monsterSpawn == 3)
            {                
                Battle_Orc();
            }
            
        }
        public void Scene_FindMonster2()
        {
            Console.Clear();
            Random random = new Random();
            int monsterSpawn = random.Next(4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 당신은 몬스터를 마주했습니다.");
            Console.ReadKey();
            if (monsterSpawn == 0 || monsterSpawn == 1)
            {
                Battle_Dog();
            }
            else if (monsterSpawn == 2)
            {
                Battle_Zombie();
            }
            else if (monsterSpawn == 3)
            {
                Battle_Orc();
            }
            
        }
        public void Scene_FindBoss()
        {
            Console.Clear();
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 당신은 드디어 당신의 고향인 왕국을 망하게 만든...");
            Console.WriteLine(" 오크들의 수장 오우거를 마주했습니다..");
            Console.ReadKey();
            
           
            
        }
        public void Scene_Town()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("안락해보이는 마을에 도착했습니다.");
            Console.WriteLine("눈에 보이는 여관에 들어가 잠을 청합니다.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("체력이 모두 회복됩니다.");
            Console.ResetColor();
            stat.Cur_Hp = stat.Max_Hp;
            Console.ReadKey();

            
        }

        public void Scene_Town2()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("반쯤 폐허가 된 마을에 도착했습니다.");
            Console.WriteLine("다행히 온전한 여관이 있어 들어가 잠을 청합니다.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("체력이 모두 회복됩니다.");
            Console.ResetColor();
            stat.Cur_Hp = stat.Max_Hp;
            Console.ReadKey();

            
        }



        public void Scene_Inventory()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

        }
        public void Logout()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                      게임을 종료합니다.");
            Console.WriteLine();
            Console.WriteLine("                         The    END");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            
        }
        public void Scene_Ending()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("            당신은 고향을 망가뜨린 철천지 원수, 오우거를 쓰렸트렸습니다.");
            Console.WriteLine("            그러나 격렬한 전투 끝에 당신도 상처를 입었고..");
            Console.WriteLine("            끝내 당신도 쓰러지고 말았습니다.");
            Console.WriteLine("            당신은 본 사람도 들은 사람도 없이 쓸쓸히 죽어갔지만");
            Console.WriteLine("            많은 이들의 원수를 갚은 영웅으로 인생을 끝맺었습니다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                           The     END");
            Console.WriteLine();
            Console.ReadKey();

        }

    }
}
