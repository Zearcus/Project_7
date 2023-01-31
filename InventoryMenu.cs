﻿using Project_7;
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
        public ConsoleKey InventoryKey;
        //bool InventoryFunction = false;
        public bool OpenCloseInventory = false;

        public InventoryMenu()
        {
            InventoryKeyCode();
        }

        public void ShowMenu()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Equipements : \n");
            foreach (ItemBase item in Inventory.Equipements)
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
            foreach (ItemBase item in Inventory.Backpack)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
            }
            OpenCloseInventory = true;
        }

        public void InventoryKeyCode()
        {
            InventoryKey = Console.ReadKey().Key;
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


            if (InventoryKey == ConsoleKey.E && OpenCloseInventory == false)
            {
                Console.Clear();
                ShowMenu();

                if(InventoryKey == ConsoleKey.E && OpenCloseInventory == true) {
                    OpenCloseInventory= false;
                }
            }
        }
    }
}

