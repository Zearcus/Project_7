using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class WeaponInit
    {
        static Dictionary<string, Weapons> _WeaponsList;

        public static Dictionary<string, Weapons> WeaponsList { get => _WeaponsList; }
        static WeaponInit() 
        {
            _WeaponsList = new Dictionary<string, Weapons>()
            {
                {"Glaive", new Weapons(10)},
                {"Sword", new Weapons(10)}
            };
        }
    }
}
