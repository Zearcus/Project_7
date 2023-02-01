using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    internal class Quadrillator :Entities
    {
        public Quadrillator()
        {
            Init();
            MakeMove();
        }

        private void Init()
        {
            Token = 'Q';
        }

        public void MakeMove()
        {
            PosX = 10;
        }
    }
}
