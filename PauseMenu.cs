using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Project_7
{
    internal class PauseMenu
    {
        public ConsoleKey PauseKey;
        public bool OpenClosePause = false;
        InventoryMenu inventory = new InventoryMenu();

        public void ShowPause()
        {
            Console.Clear();
            Console.WriteLine("Escape : Resume");
            Console.WriteLine("I : Inventoryxdqsfvssdvg");
            Console.WriteLine("O : Save");
            Console.WriteLine("P : Quit");
            OpenClosePause = true;
        }
        public void PauseKeyCode()
        {
            PauseKey = Console.ReadKey().Key;


            // Open and Close Pause menu
            if (PauseKey == ConsoleKey.Escape && OpenClosePause == false)
            {
                Console.Clear();
                ShowPause();

                if (PauseKey == ConsoleKey.Escape && OpenClosePause == true)
                {
                    OpenClosePause = false;
                }
            }

            //Open and Close Inventory menu
            if (PauseKey == ConsoleKey.I && OpenClosePause == false)
            {
                Console.Clear();
                inventory.ShowMenu();

                if (PauseKey == ConsoleKey.I && OpenClosePause == true)
                {
                    OpenClosePause = false;
                }
            }

            //Open and Close Save menu

            //Quit the game
            if (PauseKey == ConsoleKey.P)
            {
                Environment.Exit(0);
            }

        }
    }
}*/
