using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public abstract class Entities
    {
        //Entities variables part
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public int CurrentMp { get; set; }
        public int MaxMp { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public char Token { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public int LVL2 = 50;
        public int LVL3 = 120;
        public int LVL4 = 260;

    }

}
