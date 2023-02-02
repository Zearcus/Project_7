using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class PauseMenu
    {
        public ConsoleKey PauseKey;
        public bool OpenClosePause = false;
        InventoryMenu inventory = new InventoryMenu();
        public bool Verify = false;

        public void ShowPause()
        {
            Console.Clear();
            Console.WriteLine("Escape : Resume");
            Console.WriteLine("I : Inventory");
            Console.WriteLine("O : Save");
            Console.WriteLine("P : Quit");
            Verify = true;
        }
        public void PauseKeyCode(GameMap _map, int[] _Playerpos)
        {
            //PauseKey = Console.ReadKey().Key;
            ConsoleKeyInfo PauseKey;
            PauseKey = Console.ReadKey();

            // Open and Close Pause menu
            if (PauseKey.Key == ConsoleKey.Escape && OpenClosePause == false)
            {
                //Console.Clear();
                
                //Open and Close Inventory menu
                if (PauseKey.Key == ConsoleKey.I && Verify == true)
                {
                    Console.Clear();
                    inventory.ShowMenu();
                }
                else if (PauseKey.Key == ConsoleKey.I && inventory.OpenCloseInventory == true)
                {
                    ShowPause();
                    OpenClosePause = true;
                }

                //Open and Close Save menu

                //Quit the game
                if (PauseKey.Key == ConsoleKey.P && Verify == true)
                {
                    Environment.Exit(0);
                }
               // OpenClosePause = true;
            }
            else if (PauseKey.Key == ConsoleKey.Escape && OpenClosePause == true)
            {
                OpenClosePause = false;
                Console.Clear();
                _map.show(_Playerpos,ConsoleKey.A);
            }

            

        }
    }
}
