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
            e.CurrentHp -= dmg;
            Console.WriteLine("You dealt " + e.CurrentHp);
            p.CurrentMp -= cost;
            Console.WriteLine(p.CurrentMp);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
