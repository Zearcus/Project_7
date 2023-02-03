using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class NPC : NPCState
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
        }
    }
}
