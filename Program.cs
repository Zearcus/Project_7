using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Program : StartMenu
    { 

        static void Main(string[] args)
        {
            StartMenu menu = new StartMenu();
            menu.ShowMenu();

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
