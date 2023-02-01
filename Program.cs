using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Program
    { 

        static void Main(string[] args)
        {

            StartMenu menu = new StartMenu();
            

            if(menu.StartBool == true)
            {
                Console.WriteLine("Welcome dear traveller");
                InventoryMenu inventory = new InventoryMenu();
                GameMap _map = new GameMap();
                Player player = new Player();
                Quadrillator quadrillator = new Quadrillator();
                NPC npc = new NPC();
               

                //Console.WriteLine("Press E to open the inventory");
                

                _map.Init();
                player.Init();
                npc.Init();
                while (true)
                {

                    ConsoleKey input = player.keypressed(_map);
                    _map.show(player._Playerpos, input);

                    if (inventory.OpenCloseInventory == false)
                    {
                        inventory.InventoryKeyCode(input);
                    }
                }
            }

        }
    }
}
