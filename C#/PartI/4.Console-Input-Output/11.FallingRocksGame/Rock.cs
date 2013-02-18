using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FallingRocksGame
{
    public class Rock
    {
        public int x = 0;
        public int y = 0;
        public ConsoleColor color;
        public char rock;
        public Rock(int x, int y, ConsoleColor color, char rock)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.rock = rock;
        }
    }
}
