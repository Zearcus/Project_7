using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Player : Entities
    {
<<<<<<< Updated upstream:Player.cs

=======
        public Player() 
        {
            CurrentHp = 20;
            MaxHp = 20;
            CurrentMp = 20;
            Level = 1;
            Strenght = 5;
        }
>>>>>>> Stashed changes:Entities/Player.cs
        public int[] _Playerpos { get; set; }
        public void Init()
        {
            _Playerpos = new int[2];
            _Playerpos[0] = 15;
            _Playerpos[1] = 60;
        }
        

        public ConsoleKey keypressed(GameMap map)
        {

            ConsoleKey _Player;
            _Player = Console.ReadKey(true).Key;
            switch (_Player)
            {
                case ConsoleKey.Q:
                    if (map.GetMap()[_Playerpos[0], _Playerpos[1] - 1] != 'X')
                    {
                        _Playerpos[1]--;
                    }
                    break;
                case ConsoleKey.D:
                    if (map.GetMap()[_Playerpos[0], _Playerpos[1] + 1] != 'X')
                    {
                        _Playerpos[1]++;
                    }
                    break;
                case ConsoleKey.S:
                    if (map.GetMap()[_Playerpos[0] + 1, _Playerpos[1]] != 'X')
                    {
                        _Playerpos[0]++;
                    }
                    break;
                case ConsoleKey.Z:
                    if (map.GetMap()[_Playerpos[0] - 1, _Playerpos[1]] != 'X')
                    {
                        _Playerpos[0]--;
                    }
                    break;
                default:
                    break;
            }
            return _Player;
        }
    }
}
