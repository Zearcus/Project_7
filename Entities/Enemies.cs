using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Enemies : Entities
    {
        public Enemies(string Name) 
        {
            Mobs(Name);
        }   

        public void Mobs(string Name)
        {
            switch (Name) 
            {
                case "Quadrillator":
                    CurrentHp = 150;
                    MaxHp = 150;
                    CurrentMp = 20;
                    MaxMp = 20;
                    Armor = 8;
                    Strenght = 10;
                    Speed = 5;
                    Exp = 50;
                    Level = 5;                    
                    break;

                case "Square":
                    CurrentHp = 44;
                    MaxHp = 44;
                    CurrentMp = 4;
                    MaxMp = 4;
                    Armor = 4;
                    Strenght = 4;
                    Speed = 4;
                    Exp = 4;
                    Level = 4;
                    break;

                case "Rectbie":
                    CurrentHp = 22;
                    MaxHp = 22;
                    CurrentMp = 2;
                    MaxMp = 2;
                    Armor = 2;
                    Strenght = 2;
                    Speed = 2;
                    Exp = 2;
                    Level = 2;
                    break;
            }
        }
    }
}
