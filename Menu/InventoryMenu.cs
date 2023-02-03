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

            Console.WriteLine(WeaponInit.WeaponsList["Glaive"]._dmg);

            Console.WriteLine("======================================");
            Console.WriteLine("\nItems in backpack : \n");
            //foreach (ItemBase item in Inventory.Backpack)
            //{
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++²&²  &   Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Description);
            //}
            
        }
    }
}

