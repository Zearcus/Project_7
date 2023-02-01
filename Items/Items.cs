using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public abstract class Items
    {
        public int _Value { get; set; }   
        public string _desc { get; set; }

        public Items(int value, string Description) 
        {
            _Value = value;
            _desc = Description;
        }

    }
}
