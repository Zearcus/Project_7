using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Consumables
    {
        public int _heal { get; set; }
        public int _left { get; set; }

        public Consumables(int Healing, int Number) 
        { 
            _heal = Healing;
            _left = Number;
        }
        public void Heal (int Healing,int Number, Player p)
        {
            p.CurrentHp += Healing;
            Number -= 1;
            Console.WriteLine("You got healed for " + Healing + ".");
            if (p.CurrentHp >= p.MaxHp) 
            { 
                p.CurrentHp = p.MaxHp;
            }

            if (Number <= 0)
            {
                Console.WriteLine("You don't have anymore potion");
            }
        }
    }
}
