using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class ConsumablesInit
    {
        static Dictionary<string, Consumables> _ConsumablesList;

        public static Dictionary<string, Consumables> ConsumablesList { get => _ConsumablesList; }

        static ConsumablesInit() 
        {
            _ConsumablesList = new Dictionary<string, Consumables>()
            {
                {"Potion", new Consumables(15,3)},
            };
        }
    }
}
