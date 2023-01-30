using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class GameMap
    {
        char[,] _Map;
        public int[] _posX { get; set; }
        public int[] _posY { get; set; }

        public void Init()
        {
            _posX = new int[4];
            _posY = new int[4];

            _posX[0] = 15;
            _posX[1] = 15;
            _posX[2] = 45;
            _posX[3] = 15;

            _posY[0] = 60;
            _posY[1] = 60;
            _posY[2] = 180;
            _posY[3] = 60;

            _Map = new char[60, 240];
            int x = 0;
            int y = 0;
            string[] lines = System.IO.File.ReadAllLines(@"../../../maptest.txt");
            foreach (string line in lines)
            {
                x++;
                foreach (char c in line)
                {
                    y++;
                    _Map[x, y] = c;
                }
                y = 0;
            }
            x = 0;
        }

        public void show(int[] _Playerpos)
        {
            ConsoleKey _Testpos;
            _Testpos = Console.ReadKey().Key;
            Console.SetCursorPosition(0, 0);

            for (int i =_Playerpos[0] - _posX[0]; i < _Playerpos[0] + _posX[1]; i++)
            {
                for (int j =_Playerpos[1] - _posY[0]; j < _Playerpos[1] + _posY[1]; j++)
=======
            for (int i = 0; i < _Map.GetLength(0) / 2 ; i++)
            {
                for (int j = 0 ; j < _Map.GetLength(1) / 2; j++)

                {
                    //bordure de map 
                    if (_Playerpos[0] <= _posX[0])
                    {
                        _posX[0]--;
                        _posX[1]++;
                    }
                    else if (_Playerpos[0] >= _posX[2])
                    {
                        _posX[1]--;
                        _posX[2]++;
                        _posX[0]++;
                    }
                    else if (_Playerpos[1] <= _posY[0])
                    {
                        _posY[0]--;
                        _posY[1]++;
                    }
                    else if (_Playerpos[1] >= _posY[2])
                    {
                        _posY[1]--;
                        _posY[2]++;
                        _posY[0]++;
                    }
                    //inversement retour au milieu de map
                    if (_Testpos == ConsoleKey.S && _posX[0] < 16)
                    {
                        _posX[0]++;
                        _posX[1]--;
                    }
                    else if (_Testpos == ConsoleKey.Z && _posX[2] > 44)
                    {
                        _posX[1]++;
                        _posX[2]--;
                        _posX[0]--;
                    }
                    else if (_Testpos == ConsoleKey.D && _posY[0] < 60)
                    {
                        _posY[0]++;
                        _posY[1]--;
                    }
                    else if (_Testpos == ConsoleKey.Q && _posY[2] > 179)
                    {
                        _posY[1]++;
                        _posY[2]--;
                        _posY[0]--;
                    }

                    switch (_Map[i, j])
                    {
                        case '#':
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case '~':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 'X':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case ' ':
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        default:
                            break;
                    }
                    if (i == _Playerpos[0] && j == _Playerpos[1])
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write('P');
                    }
                    else
                    {
                        Console.Write(_Map[i, j]);
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
    }
}
