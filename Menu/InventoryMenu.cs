/*using Project_7;
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
        public void ShowMenu()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Equipements : \n");
            foreach (ItemBase item in Inventory._Equipements)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Name);
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
            }
            Console.WriteLine("======================================");
            Console.WriteLine("\nItems in backpack : \n");
            foreach (ItemBase item in Inventory._Backpack)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
            }
        }
    }
}*/

