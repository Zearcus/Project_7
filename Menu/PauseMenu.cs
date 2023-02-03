using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    internal class PauseMenu
    {
        public bool OpenClosePause = false;
        InventoryMenu inventory = new InventoryMenu();

        public void ShowPause()
        {
            Console.Clear();
            Console.WriteLine("1) Resume");
            Console.WriteLine("2) Inventory");
            Console.WriteLine("3) Save");
            Console.WriteLine("4) Quit the game");
        }

        public void PauseClose(GameMap _map, int[] _Playerpos, ConsoleKey input)
        {
            if (input == ConsoleKey.D1)
            {
                _map.show(_Playerpos, input);
                OpenClosePause = false;
            }
        }

        public void InventoryOpenClose(ConsoleKey input)
        {
            if (input == ConsoleKey.D2)
            {
                while (inventory.OpenCloseInventory == false)
                {
                    inventory.ShowInventory();
                    input = Console.ReadKey().Key;
                    if (input == ConsoleKey.D2 && inventory.OpenCloseInventory == false)
                    {
                        inventory.OpenCloseInventory = true;
                        ShowPause();
                    }
                }
                inventory.OpenCloseInventory = false;
            }
        }

        public void QuitOpenClose(ConsoleKey input)
        {
            if(input == ConsoleKey.D4)
            {
                Environment.Exit(0);
            }
        }
    }
}
