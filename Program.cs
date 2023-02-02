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
                Console.WriteLine("Welcome dear traveller");
                Console.WriteLine("Press Escape to open the menu");
                Console.WriteLine("Press Space to open the game");


                GameMap _map = new GameMap();
                Player player = new Player();
                NPC npc = new NPC();



                PauseMenu pause = new PauseMenu();
                Battle battle = new Battle();

                _map.Init();
                player.Init();
                npc.Init();
                while (true)
                {
                    ConsoleKey input = player.keypressed(_map, npc, npc.NPCpos);
                    _map.show(player._Playerpos, input);
                    if (pause.OpenClosePause == false)
                    {
                        pause.PauseKeyCode(_map, player._Playerpos, input);
                        while (pause.OpenClosePause == true)
                        {
                            pause.ShowPause(input);
                            System.Threading.Thread.Sleep(3000);
                            pause.PauseKeyCode(_map, player._Playerpos, input);
                        }
                    }
                    while (player.battle == true)
                    {
                        Console.WriteLine("kjhdjkfksdjflikdjilfjsdlikgjjkfdgfjkdjgkjdfjkgjjkdfgkjhdf");
                    }
                }

                //battle.BattleScene();
            }



        }
    }
}
