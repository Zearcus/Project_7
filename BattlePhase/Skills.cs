using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Skills
    {
        int _Dmg { get; set; }
        int _MpCost { get; set; }

        public Skills(int dmg, int cost) 
        {
            _Dmg = dmg;
            _MpCost = cost;
        }

        public void HeavySlash(int dmg, int cost, Enemies e, Player p)
        { 
            e.CurrentHp -= (p.Strenght += dmg / e.Armor);
            Console.WriteLine("You dealt " + e.CurrentHp + " to the enemy.");
            p.CurrentMp -= cost;
            Console.WriteLine("You have " + p.CurrentMp + " mp left.");
            System.Threading.Thread.Sleep(1000);

            if (p.CurrentMp <= 0) 
            {
                p.CurrentMp = 0;
                Console.WriteLine("You don't have enough mp !");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
