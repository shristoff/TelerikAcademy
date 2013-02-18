//zadachata ne e zavyrshena, no chastichno raboti.

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using _11.FallingRocksGame;

namespace FallingRocks
{
    class FallingRocksGame
    {
        static char[,] Rocks = new char[Console.WindowWidth, Console.WindowHeight];
        static int[,] colors = new int[Console.WindowWidth, Console.WindowHeight];
        static char[] RockTypes = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-', '?' };
        static int RocksNumber;
        static int RocksPositionX = 0;
        static int RocksPositionY = 0;
        static int DwarfPositionX = 0;
        static int DwarfPositionY = 0;
        static int Lives = 3;
        static Random randomGenerator = new Random();

        static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        static void InitScreen()
        {
            for (int y = 0; y < Console.WindowHeight; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    Rocks[x, y] = ' ';
                    colors[x, y] = (int)ConsoleColor.Black;
                }
            }
        }

        static void PrintAtPosition(int x, int y, char symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        static void PrintScreen()
        {
             for (int y = 0; y < Console.WindowHeight - 1; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    PrintAtPosition(x,y,Rocks[x,y],(ConsoleColor)(colors[x,y]));
                    Result();
                }
            }
        }

        static void DrawDwarf()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(DwarfPositionX, DwarfPositionY);
            Console.Write("(O)");
        }

        static void SetDwarfInitialPosition()
        {
            DwarfPositionX = Console.WindowWidth / 2;
            DwarfPositionY = Console.WindowHeight - 1;
        }


        static void ClearTheRow(int y)
        {
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                Rocks[x, y] = ' ';
            }
        }
            
        static void GenerateRandomFirstRow() 
        {
            int RocksNumber = randomGenerator.Next(0, 12); // choose number of rocks to show
            for (int i = 0; i < RocksNumber; i++) 
            {
                int RocksPositionX = randomGenerator.Next(0, Console.WindowWidth);
                int RockType = randomGenerator.Next(0, 13);
                int color = randomGenerator.Next(1, 15);
                Rocks[RocksPositionX, 0] = RockTypes[RockType];
                colors[RocksPositionX, 0] = color;
            }
        }

        static void MoveDown()
        {
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                for (int y = Console.WindowHeight - 1; y > 0; y--)
                {
                    Rocks[x, y] = Rocks[x, y - 1];
                    colors[x, y] = colors[x, y - 1];
                }
            }
        }

        static void MoveDwarfLeft()
        {
            if (DwarfPositionX > 0)
            {
                DwarfPositionX--;
            }
        }

        static void MoveDwarfRight()
        {
            if (DwarfPositionX < Console.WindowWidth)
            {
                DwarfPositionX++;
            }
        }

        static void Result()
        {
            Console.SetCursorPosition(0, Console.WindowHeight/2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Lives left: {0}", Lives);
         }

        static void Main()
        {
            //List<Rock> l = new List<Rock>();
            //Rock r = new Rock(5, 7, ConsoleColor.Black, '*');
            //l.Add(r);
            //foreach (var item in l)
            //{
            //    item.y
            //        ++;
            //}
            
            Console.OutputEncoding = Encoding.UTF8;
            RemoveScrollBars();
            SetDwarfInitialPosition();
            InitScreen();
            
            while (true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        MoveDwarfLeft();
                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        MoveDwarfRight();
                    }
                }
                    if (Rocks[RocksPositionX, Console.WindowHeight - 1] != ' ' && RocksPositionX == DwarfPositionX)
                    {
                        Lives--;
                    }

                PrintScreen();
                DrawDwarf();
                
                MoveDown();
                ClearTheRow(0);
                GenerateRandomFirstRow();
            }
        }
    }
}
/*Rocks[]
Extract random number of array elements
Print the random rocks on the highest line
Print the dwarf on the first line
Move the dwarf Left and Right
Move the rocks down
Collision case
Result - lines of Rocks cleared
Speed increase after some result*/
