using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Actions
    {
        public string Name { get; }
        public Action Selected { get; }

        public Actions (string name, Action selected)
        {
            Name = name;
            Selected = selected;
        }
    }
}
