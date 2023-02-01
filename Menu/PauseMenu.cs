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
        public ConsoleKey PauseKey;
        public bool OpenClosePause = false;
        InventoryMenu inventory = new InventoryMenu();
        public bool Verify = false;

        public void ShowPause()
        {
            Console.Clear();
            Console.WriteLine("_Escape : Resume");
            Console.WriteLine("I : Inventory");
            Console.WriteLine("O : Save");
            Console.WriteLine("P : Quit");
            
        }
        public void PauseKeyCode(GameMap _map, int[] _Playerpos)
        {
            //PauseKey = Console.ReadKey().Key;
            ConsoleKeyInfo PauseKey;
            PauseKey = Console.ReadKey();

            // Open and Close Pause menu
            if (PauseKey.Key == ConsoleKey.Escape && OpenClosePause == false)
            {
                Console.Clear();
                OpenClosePause = true;

            }
            else if (PauseKey.Key == ConsoleKey.Escape && OpenClosePause == true)
            {
                OpenClosePause = false;
                Console.Clear();
                _map.show(_Playerpos,ConsoleKey.A);
            }

            //Open and Close Inventory menu
            if (PauseKey.Key == ConsoleKey.I && OpenClosePause == false)
            {
                Console.Clear();
                inventory.ShowMenu();

                if (PauseKey.Key == ConsoleKey.I && OpenClosePause == true)
                {
                    OpenClosePause = false;
                }
            }

            //Open and Close Save menu

            //Quit the game
            if (PauseKey.Key == ConsoleKey.P)
            {
                Environment.Exit(0);
            }

        }
    }
}
