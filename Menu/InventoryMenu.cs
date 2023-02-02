using Project_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class InventoryMenu
    {

        public InventoryMenu()
        {
            //InventoryKeyCode();
        }

        public bool OpenCloseInventory = false;

        public void ShowMenu()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Equipements : \n");

            Console.WriteLine(WeaponInit.WeaponsList["Glaive"]._dmg) ;

            Console.WriteLine("======================================");
            Console.WriteLine("\nItems in backpack : \n");
            //foreach (ItemBase item in Inventory.Backpack)
            //{
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++²&²  &   Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Description);
            //}
            OpenCloseInventory= true;
        }

        public void InventoryKeyCode()
        {
            //switch (InventoryKey)
            //{
            //    case ConsoleKey.E:

            //        if (OpenCloseInventory == false)
            //        {
            //            ShowMenu();
            //        }
            //        else if (OpenCloseInventory == true)
            //        {

            //        }
            //        break;
            //}


            //if (InventoryKey == ConsoleKey.E && OpenCloseInventory == false)
            //{
            //    Console.Clear();
            //    ShowMenu();

            //    if (InventoryKey == ConsoleKey.Escape && OpenCloseInventory == true)
            //    {
            //        OpenCloseInventory = false;
            //    }
            //}
        }
    }
}

