using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_GameMake
{
    internal partial class Scene
    {
        public void Chilly()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("농부가 당신을 쌀쌀맞게 쳐다봅니다.");
            Console.WriteLine(" \"넌 누구냐? 처음보는 놈인데?\" ");
            Console.WriteLine(" \"당장 꺼져\" ");
            Console.WriteLine();
            Console.WriteLine(" 당신은 처음받아보는 무례한 태도에 정신적 피해를 입습니다.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 체력 1 감소");
            Console.ResetColor();
            stat.Cur_Hp = stat.Cur_Hp - 1;
            Console.ReadKey();
            Scene_FindMonster();
        }
        public void Chilly2()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("상인이 당신을 쌀쌀맞게 쳐다봅니다.");
            Console.WriteLine(" \"넌 누구냐? 처음보는 놈인데?\" ");
            Console.WriteLine(" \"당장 꺼져\" ");
            Console.WriteLine();
            Console.WriteLine(" 당신은 처음받아보는 무례한 태도에 정신적 피해를 입습니다.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 체력 1 감소");
            Console.ResetColor();
            stat.Cur_Hp = stat.Cur_Hp - 1;
            Console.ReadKey();
            Scene_FindMonster();
        }

        public void Help()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" \"혹시 저를 도와줄 수 있습니까..?\" ");
            Console.WriteLine(" \"사례는 하도록 하겠습니다..!\" ");
            Console.WriteLine();
            Console.WriteLine("부탁을 거절할 수 없던 당신은 사정을 듣고");
            Console.WriteLine("몬스터를 처치해주기로 했습니다.");
            Console.WriteLine();
            Console.ReadKey();

            Scene_FindMonster();
        }
        public void Beaten()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("당신은 농부를 공격했습니다.");
            Console.WriteLine();
            Console.WriteLine(" \" 안그래도 기분도 안좋았는데 너 잘걸렸다\" ");
            Console.WriteLine("생각보다 농부가 강했습니다..");
            Console.WriteLine();
            if (stat.Dclass >= 10)
                Console.WriteLine("당신은 역으로 두들겨 맞을뻔 하다 간신히 도망쳤습니다.");
            else
            {
                Console.WriteLine("당신은 역으로 두들겨 맞았습니다..");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" HP 1 감소");
                Console.ResetColor();
                stat.Cur_Hp -= 1;
            }
            Console.ReadKey();

            Scene_FindMonster();
        }
        public void Beaten2()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("당신은 상인을 공격했습니다.");
            Console.WriteLine();
            Console.WriteLine(" \" 지금 날 때린거야?\" ");
            Console.WriteLine("상인의 옆에 서있던 용병들이 뛰어 나왔습니다.");
            Console.WriteLine();
            if (stat.Dclass >= 10)
                Console.WriteLine("당신은 역으로 두들겨 맞을뻔 하다 간신히 도망쳤습니다.");
            else
            {
                Console.WriteLine("당신은 역으로 두들겨 맞았습니다..");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" HP 2 감소");
                Console.ResetColor();
                stat.Cur_Hp -= 2;
            }
            Console.ReadKey();

            Scene_FindMonster();
        }
        public void Beat()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("당신은 농부를 공격했습니다.");
            Console.WriteLine();
            Console.WriteLine(" \" 왜.. 왜그러시는거예요..\" ");
            Console.WriteLine(" \" 가진건 이거밖에 없어요 이거라도 드릴테니 그만해주세요..\" ");
            Console.WriteLine();
            Console.WriteLine(" 당신은 아이템을 넘겨받고 가던길을 마저 갔습니다.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("스멜링 솔트 아이템 획득");
            Console.ResetColor();

            Console.ReadKey();
            Scene_FindMonster();
        }
        public void Beat2()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("당신은 상인을 공격했습니다.");
            Console.WriteLine("당신이 너무 강해보여 옆에 있던 용병들도 나서지 못하였습니다.");
            Console.WriteLine();
            Console.WriteLine(" \" 왜.. 왜그러시는거예요..\" ");
            Console.WriteLine(" \" 가진건 이거밖에 없어요 이거라도 드릴테니 그만해주세요..\" ");
            Console.WriteLine();
            Console.WriteLine(" 당신은 아이템을 넘겨받고 가던길을 마저 갔습니다.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("스테로이드 아이템 획득");
            Console.ResetColor();

            Console.ReadKey();
            Scene_FindMonster();
        }

        public int Str_Win()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}에게 정면에서 공격을 시도합니다.");
            Console.WriteLine("정면 공격에 성공하였습니다.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {monsterS} Hp 1 감소");
            Console.ResetColor();
            Console.ReadKey();
            return monsterHp--;
        }
        public int Str_lose()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}에게 정면에서 공격을 시도합니다.");
            Console.WriteLine($"당신은 너무 약해서 정면 공격이 통할 리가 없습니다..");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 당신의 Hp 1 감소");
            Console.ResetColor();
            Console.ReadKey();
            return playerHp--;
        }
        public int Dex_Win()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}의 뒤에서 기습을 시도합니다.");
            Console.WriteLine("당신의 기습 공격이 성공하였습니다.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {monsterS} Hp 2 감소");
            Console.ResetColor();
            Console.ReadKey();
            return monsterHp = monsterHp -2;
        }
        public int Dex_lose()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}의 뒤에서 기습을 시도합니다.");
            Console.WriteLine("당신의 느려터진 속도로는 기습을 성공할 리가 없습니다..");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 당신의 Hp 2 감소");
            Console.ResetColor();
            Console.ReadKey();
            return playerHp = playerHp - 2;
        }
        public int Int_Win()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}에게 마비 마법을 시전합니다.");
            Console.WriteLine("당신의 마비 마법이 성공하였습니다.");
            Console.WriteLine("마비 당한 몬스터에게 공격을 가하였습니다.") ;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {monsterS} Hp 1 감소");
            Console.ResetColor();
            Console.ReadKey();
            return monsterHp --;
        }
        public int Int_lose()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}에게 마비 마법을 시전합니다.");
            Console.WriteLine("당신의 형편없는 지능으로 마법을 시전할 수 있을 리가 없습니다...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 당신의 Hp 2 감소");
            Console.ResetColor();
            Console.ReadKey();
            return playerHp = playerHp - 2;
        }
        public int Run_SSuc()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}에게서 도망을 시도합니다.");
            Console.WriteLine("간신히 도망치는데 성공했습니다..");
            Console.WriteLine();
            
            Console.ReadKey();
            return playerHp;
        }
        public int Run_Suc()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}에게서 도망을 시도합니다.");
            Console.WriteLine("간신히 도망치는데 성공했으나 도망치던 중 적에 공격에 맞았습니다..");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 당신의 Hp 1 감소");
            Console.ResetColor();
            Console.ReadKey();
            return playerHp--;
        }
        public int Run_Fail()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{monsterS}에게서 도망을 시도합니다.");
            Console.WriteLine("도망치려고 하는 순간 돌뿌리에 걸려 넘어졌습니다..");
            Console.WriteLine($"무방비 상태가 된 당신은 {monsterS}의 저녁밥이 되었습니다..") ;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("사망..");
            Console.ResetColor();
            Console.ReadKey();
            return playerHp = 0;
        }
    }
}
