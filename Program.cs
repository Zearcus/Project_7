using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            GameMap _map = new GameMap();
            Player player = new Player();
            Quadrillator quadrillator = new Quadrillator();
            InventoryMenu inventory = new InventoryMenu();

            inventory.ShowMenu();

            _map.Init();
            player.Init();
            do

            {   
                _map.show(player._Playerpos);
                player.keypressed();
            } while(true);



        }
    }
}
