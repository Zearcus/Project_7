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
            _Playerpos[0] = 15;
            _Playerpos[1] = 60;

        }

        public void keypressed()
        {

            ConsoleKey _Player;
            _Player = Console.ReadKey().Key;
            switch (_Player)
            {
                case ConsoleKey.Q:
                    _Playerpos[1]--;
                    break;
                case ConsoleKey.D:
                    _Playerpos[1]++;
                    break;
                case ConsoleKey.S:
                    _Playerpos[0]++;
                    break;
                case ConsoleKey.Z:
                    _Playerpos[0]--;
                    break;
                default:
                    break;
            }
=======
        public Player() {
            Init();

        }
=======

        private void Init()
        {
            Token = 'P';
            Hp = 20;
            Armor = 20;
            PosX = 20;
            PosY = 20;
        }
    }
}
