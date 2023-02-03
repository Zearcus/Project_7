using Project_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    internal class InventoryMenu
    {
        public bool OpenCloseInventory = false;

        public void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("Equipements : \n");

            Console.WriteLine("Glaive " + WeaponInit.WeaponsList["Glaive"]._dmg + "STR") ;
            Console.WriteLine("Sword " + WeaponInit.WeaponsList["Sword"]._dmg + "STR");

            Console.WriteLine("======================================");
            Console.WriteLine("\nItems in backpack : \n");

            Console.WriteLine("Potion heals you for " + ConsumablesInit.ConsumablesList["Potion"]._heal + " there is still " + ConsumablesInit.ConsumablesList["Potion"]._left + "Potion");
            OpenCloseInventory = true;

        }
    }
}

