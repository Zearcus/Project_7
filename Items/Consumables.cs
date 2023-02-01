using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Consumables
    {
        int _heal { get; set; }

        public Consumables(int Healing) 
        { 
            _heal = Healing;
        }
        public void Heal (int Healing, Player p)
        {
            p.CurrentHp += Healing;
            Console.WriteLine("You got healed for " + Healing + ".");
            if (p.CurrentHp >= p.MaxHp) 
            { 
                p.CurrentHp = p.MaxHp;
            }
        }
    }
}
