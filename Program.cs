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
               

                //Console.WriteLine("Press E to open the inventory");
                

                _map.Init();
                player.Init();
                do

                {
                    _map.show(player._Playerpos);
                    if(inventory.OpenCloseInventory == false)
                    {
                        inventory.InventoryKeyCode();
                    }
                    player.keypressed();
                } while (true);
            }

        }
    }
}
