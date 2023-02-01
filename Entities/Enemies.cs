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
            CurrentMp = 20;
            Level = 1;
            Strenght = 5;
        }   
    }
}
