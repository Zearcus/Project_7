﻿using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Program
    {

        static void Main(string[] args)
        {

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
            Console.WriteLine("\nItems in backpack:");
            foreach (ItemBase item in Inventory.Backpack)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
            }
=======
            GameMap _map = new GameMap();
            Player player = new Player();
            Quadrillator quadrillator = new Quadrillator();

            _map.Init();
            do
            {
                //player.keypressed();
                _map.show();
            } while (true);


        }
    }
}
