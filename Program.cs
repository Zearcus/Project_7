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
                Console.WriteLine("Press Escape to open the menu");
                
                
                GameMap _map = new GameMap();
                Player player = new Player();
                Quadrillator quadrillator = new Quadrillator();
                NPC npc = new NPC();
               

                //Console.WriteLine("Press E to open the inventory");
                
                PauseMenu pause = new PauseMenu();
                //Quadrillator quadrillator = new Quadrillator();

                _map.Init();
                player.Init();
                npc.Init();
                while (true)
                {

                    
                    if(pause.OpenClosePause == false)
                    {
                        pause.PauseKeyCode();
                    }
                    ConsoleKey input = player.keypressed(_map);
                    _map.show(player._Playerpos, input);
                }
            }
            Battle battle = new Battle();
            battle.BattleScene();


        }
    }
}
