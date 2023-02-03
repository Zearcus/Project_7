using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StartMenu menu = new StartMenu();


            if (menu.StartBool == true)
            {
                
                Console.WriteLine("Story :");
                Console.WriteLine("====================================================================================================================");
                Console.WriteLine("you are a square-less who is trying to put an end to the cube order that has long reigned over the SQUARE region");
                Console.WriteLine("====================================================================================================================");

                Console.WriteLine("Information : ");
                Console.WriteLine("====================================================================================================================");
                Console.WriteLine("You can move with the ZQSD keys");
                Console.WriteLine("Z : make move in forward");
                Console.WriteLine("Q : make move in left");
                Console.WriteLine("S : make move in back");
                Console.WriteLine("D : make move in right");

                Console.WriteLine("====================================================================================================================");
                Console.WriteLine("You can press 1 to open the menu");
                Console.WriteLine("You can press other button to open the game");

                GameMap _map = new GameMap();
                Player player = new Player();
                NPC npc = new NPC();
                InventoryMenu inventory = new InventoryMenu();
                PauseMenu pause = new PauseMenu();




                _map.Init();
                player.Init();
                npc.Init();
                while (true)
                {
                    ConsoleKey input = player.keypressed(_map, npc, npc.NPCpos);
                    if (input == ConsoleKey.D1)
                    {
                        pause.OpenClosePause = true;
                        while (pause.OpenClosePause == true)
                        {
                            pause.ShowPause();
                            input = Console.ReadKey().Key;

                            // invenotory input part
                            pause.InventoryOpenClose(input);

                            //Close pause menu part
                            pause.PauseClose(_map, player._Playerpos, input);

                            //Close game part
                            pause.QuitOpenClose(input);
                        }
                    }
                    _map.show(player._Playerpos, input);
                    while (player.battle == true)
                    {
                        Battle battle = new Battle();
                        battle.BattleScene();
                    }

                }
            }
        }
    }
}
