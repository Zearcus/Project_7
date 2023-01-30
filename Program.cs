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
                GameMap _map = new GameMap();
                Player player = new Player();
                Quadrillator quadrillator = new Quadrillator();
                InventoryMenu inventory = new InventoryMenu();

                Console.WriteLine("Press E to open the inventory");
                

                _map.Init();
                player.Init();
                do

                {
                    _map.show(player._Playerpos);
                    player.keypressed();
                } while (true);
            }

        }
    }
}
