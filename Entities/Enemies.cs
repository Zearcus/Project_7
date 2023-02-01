using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Enemies : Entities
    {
        public Enemies() 
        {
            CurrentHp = 20;
            MaxHp = 20;
            CurrentMp = 20;
            MaxMp = 20;
            Exp = 10;
            Speed = 3;
            Level = 1;
            Strenght = 5;
        }   
    }
}
