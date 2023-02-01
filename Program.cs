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
                NPC npc = new NPC();
               

                
                PauseMenu pause = new PauseMenu();

                _map.Init();
                player.Init();
                npc.Init();
                while (true)
                {
                    if(pause.OpenClosePause == false)
                    {
                        pause.PauseKeyCode(_map, player._Playerpos);
                        while (pause.OpenClosePause == true)
                        {
                            pause.ShowPause();
                            pause.PauseKeyCode(_map,player._Playerpos);
                            
                        }
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
