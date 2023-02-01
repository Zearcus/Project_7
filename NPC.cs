using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    internal class NPC : NPCState
    {
        public void Init()
        {
            NPCpos = new int[2];
            NPCpos[0] = 20;
            NPCpos[1] = 59;
        }
        public void TestNPC()
        {
            Name = "pablo";
            texte = "welcome to the new world you have to level up and kill the boss the quadrillator";
        }
    }
}
