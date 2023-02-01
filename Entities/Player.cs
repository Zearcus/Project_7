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
