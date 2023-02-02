using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    public class Player : Entities
    {
        public Player() 
        {
            CurrentHp = 10;
            MaxHp = 20;
            CurrentMp = 20;
            MaxMp = 20;
            Exp = 0;
            Speed = 5;
            Level = 1;
            Strenght = 5;
        }

        public bool battle = false;
        public int[] _Playerpos { get; set; }
        public void Init()
        {
            _Playerpos = new int[2];
            _Playerpos[0] = 21;
            _Playerpos[1] = 63;

        }
        

        public ConsoleKey keypressed(GameMap map, NPC npc, int[] NPCpos)
        {

            ConsoleKey _Player;
            _Player = Console.ReadKey(true).Key;
            switch (_Player)
            {
                case ConsoleKey.Q:
                    if (map.GetMap()[_Playerpos[0], _Playerpos[1] - 1] != 'X')
                    {
                        _Playerpos[1]--;
                        if (map.GetMap()[_Playerpos[0], _Playerpos[1]] == 'W')
                        {
                            int bush = 1;
                            if (bush == 1)
                            {
                                Random test = new Random();
                                int jsp = test.Next(0, 100);
                                if (jsp <= 50)
                                {
                                    bush = 0;
                                }
                            }
                            if (bush == 0)
                            {
                                Console.Clear();
                                battle = true;
                            }
                        }
                    }
                    if (_Playerpos[0] == NPCpos[0] && _Playerpos[1] == NPCpos[1])
                    {
                        Console.Clear();
                        Console.Write("welcome to the new world you have to level up and kill the boss the quadrillator");
                        System.Threading.Thread.Sleep(3000);
                    }
                    break;
                case ConsoleKey.D:
                    if (map.GetMap()[_Playerpos[0], _Playerpos[1] + 1] != 'X')
                    {
                        _Playerpos[1]++;
                    }
                    if (_Playerpos[0] == NPCpos[0] && _Playerpos[1] == NPCpos[1])
                    {
                        Console.Clear();
                        Console.Write("welcome to the new world you have to level up and kill the boss the quadrillator");
                        System.Threading.Thread.Sleep(3000);
                    }
                    break;
                case ConsoleKey.S:
                    if (map.GetMap()[_Playerpos[0] + 1, _Playerpos[1]] != 'X')
                    {
                        _Playerpos[0]++;
                    }
                    if (_Playerpos[0] == NPCpos[0] && _Playerpos[1] == NPCpos[1])
                    {
                        Console.Clear();
                        Console.Write("welcome to the new world you have to level up and kill the boss the quadrillator");
                        System.Threading.Thread.Sleep(3000);
                    }
                    break;
                case ConsoleKey.Z:
                    if (map.GetMap()[_Playerpos[0] - 1, _Playerpos[1]] != 'X')
                    {
                        _Playerpos[0]--;
                    }
                    if (_Playerpos[0] == NPCpos[0] && _Playerpos[1] == NPCpos[1])
                    {
                        Console.Clear();
                        Console.Write("welcome to the new world you have to level up and kill the boss the quadrillator");
                        System.Threading.Thread.Sleep(3000);
                    }
                    break;
                default:
                    break;
            }
            return _Player;
        }
    }
}
