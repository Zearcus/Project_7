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
        public float CurrentHp { get; set; }
        public float MaxHp { get; set; }
        public float CurrentMp { get; set; }
        public float MaxMp { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public float Exp { get; set; }
        public char Token { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public bool IsDead;
    }

}
