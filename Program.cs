using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Program
    { 

        static void Main(string[] args)
        {

            /*StartMenu menu = new StartMenu();
            

            if(menu.StartBool == true)
            {
                Console.WriteLine("Welcome dear traveller");
                Console.WriteLine("Press Escape to open the menu");
                
                
                GameMap _map = new GameMap();
                Player player = new Player();
                PauseMenu pause = new PauseMenu();
                //Quadrillator quadrillator = new Quadrillator();

                _map.Init();
                player.Init();
                while (true)
                {
<<<<<<< Updated upstream
                    
                    if(pause.OpenClosePause == false)
                    {
                        pause.PauseKeyCode();
                    }
                    ConsoleKey input = player.keypressed(_map);
                    _map.show(player._Playerpos, input);
                }
            }
=======
                    _map.show(player._Playerpos);
                    player.keypressed();
                } while (true);
            }*/
            Battle battle = new Battle();
            battle.BattleScene();
>>>>>>> Stashed changes

        }
    }
}
