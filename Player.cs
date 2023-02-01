using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Player : Entities
    {

        public int[] _Playerpos { get; set; }
        public void Init()
        {
            _Playerpos = new int[2];
            _Playerpos[0] = 21;
            _Playerpos[1] = 63;

        }

        public ConsoleKey keypressed(GameMap map)
        {

            ConsoleKey _Player;
            _Player = Console.ReadKey(true).Key;
            switch (_Player)
            {
                case ConsoleKey.Q:
                    if (map.GetMap()[_Playerpos[0], _Playerpos[1] - 1] != 'X' || map.GetMap()[_Playerpos[0], _Playerpos[1] - 1] != '#')
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
