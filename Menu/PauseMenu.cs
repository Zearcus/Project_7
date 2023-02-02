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
        /*public ConsoleKey PauseKey;*/
        public bool OpenClosePause = false;
        InventoryMenu inventory = new InventoryMenu();
        public bool Verify = false;

        public void ShowPause(ConsoleKey input)
        {
            Console.Clear();
            Console.WriteLine("_Escape : Resume");
            Console.WriteLine("I : Inventory");
            Console.WriteLine("O : Save");
            Console.WriteLine("P : Quit");

        }
        public void PauseKeyCode(GameMap _map, int[] _Playerpos, ConsoleKey input)
        {
            //PauseKey = Console.ReadKey().Key;
            /*ConsoleKeyInfo PauseKey;
            PauseKey = Console.ReadKey();*/

            // Open and Close Pause menu
            if (input == ConsoleKey.Escape && OpenClosePause == false)
            {
                Console.Clear();
                OpenClosePause = true;

            }
            else if (input == ConsoleKey.Escape && OpenClosePause == true)
            {
                OpenClosePause = false;
                Console.Clear();
                _map.show(_Playerpos,ConsoleKey.A);
            }

            //Open and Close Inventory menu
            if (input == ConsoleKey.I && OpenClosePause == false)
            {
                Console.Clear();
                inventory.ShowMenu();

                if (input == ConsoleKey.I && OpenClosePause == true)
                {
                    OpenClosePause = false;
                }
            }

            //Open and Close Save menu

            //Quit the game
            if (input == ConsoleKey.P)
            {
                Environment.Exit(0);
            }

        }
    }
}
