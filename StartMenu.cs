using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class StartMenu
    {
       public bool StartBool = false;

        public StartMenu() {
            ShowMenu();
        }

        public void ShowMenu()
        {
            Console.WriteLine("=======================Welcome Traveller to Elden Square !=======================");
            Console.WriteLine("1 : Start");
            Console.WriteLine("2 : Quit ");
            Console.WriteLine("=================================================================================\n");

            ConsoleKey choice;
            choice = Console.ReadKey().Key;
            if (StartBool == false)
            {
                switch (choice)
                {
                    case ConsoleKey.D1:
                        StartBool = true;
                        Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        Environment.Exit(0);
                        break;
                }

            }

        }

    }
}
