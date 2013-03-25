namespace UnstoppableMickey
{
    using System;
    using System.Collections.Generic;

    public static class Map
    {
        public static List<Block> GetMap()
        {
            List<Block> blocks = new List<Block>();

            // ROW 2
            blocks.Add(new Block(new Position(2, 5)));
            blocks.Add(new Block(new Position(2, 7)));
            blocks.Add(new Block(new Position(2, 10)));
            blocks.Add(new Block(new Position(2, 14)));
            blocks.Add(new Block(new Position(2, 16)));
            blocks.Add(new Block(new Position(2, 19)));
            blocks.Add(new Block(new Position(2, 24)));
            blocks.Add(new Block(new Position(2, 26)));
            blocks.Add(new Block(new Position(2, 29)));
            blocks.Add(new Block(new Position(2, 33)));
            blocks.Add(new Block(new Position(2, 35)));

            // ROW 3
            blocks.Add(new Block(new Position(3, 3)));
            blocks.Add(new Block(new Position(3, 5)));
            blocks.Add(new Block(new Position(3, 10)));
            blocks.Add(new Block(new Position(3, 12)));
            blocks.Add(new Block(new Position(3, 14)));
            blocks.Add(new Block(new Position(3, 19)));
            blocks.Add(new Block(new Position(3, 22)));
            blocks.Add(new Block(new Position(3, 24)));
            blocks.Add(new Block(new Position(3, 29)));
            blocks.Add(new Block(new Position(3, 31)));
            blocks.Add(new Block(new Position(3, 33)));
            blocks.Add(new Block(new Position(3, 38)));

            // ROW 4
            blocks.Add(new Block(new Position(4, 3)));
            blocks.Add(new Block(new Position(4, 5)));
            blocks.Add(new Block(new Position(4, 6)));
            blocks.Add(new Block(new Position(4, 7)));
            blocks.Add(new Block(new Position(4, 8)));
            blocks.Add(new Block(new Position(4, 10)));
            blocks.Add(new Block(new Position(4, 12)));
            blocks.Add(new Block(new Position(4, 14)));
            blocks.Add(new Block(new Position(4, 15)));
            blocks.Add(new Block(new Position(4, 16)));
            blocks.Add(new Block(new Position(4, 17)));
            blocks.Add(new Block(new Position(4, 19)));
            blocks.Add(new Block(new Position(4, 20)));
            blocks.Add(new Block(new Position(4, 22)));
            blocks.Add(new Block(new Position(4, 24)));
            blocks.Add(new Block(new Position(4, 25)));
            blocks.Add(new Block(new Position(4, 26)));
            blocks.Add(new Block(new Position(4, 27)));
            blocks.Add(new Block(new Position(4, 29)));
            blocks.Add(new Block(new Position(4, 31)));
            blocks.Add(new Block(new Position(4, 33)));
            blocks.Add(new Block(new Position(4, 34)));
            blocks.Add(new Block(new Position(4, 35)));
            blocks.Add(new Block(new Position(4, 36)));
            blocks.Add(new Block(new Position(4, 38)));

            // ROW 5
            blocks.Add(new Block(new Position(5, 10)));
            blocks.Add(new Block(new Position(5, 19)));
            blocks.Add(new Block(new Position(5, 22)));
            blocks.Add(new Block(new Position(5, 29)));
            blocks.Add(new Block(new Position(5, 38)));
            blocks.Add(new Block(new Position(5, 39)));

            // ROW 6
            blocks.Add(new Block(new Position(6, 3)));
            blocks.Add(new Block(new Position(6, 4)));
            blocks.Add(new Block(new Position(6, 6)));
            blocks.Add(new Block(new Position(6, 8)));
            blocks.Add(new Block(new Position(6, 10)));
            blocks.Add(new Block(new Position(6, 12)));
            blocks.Add(new Block(new Position(6, 13)));
            blocks.Add(new Block(new Position(6, 15)));
            blocks.Add(new Block(new Position(6, 17)));
            blocks.Add(new Block(new Position(6, 19)));
            blocks.Add(new Block(new Position(6, 21)));
            blocks.Add(new Block(new Position(6, 22)));
            blocks.Add(new Block(new Position(6, 23)));
            blocks.Add(new Block(new Position(6, 25)));
            blocks.Add(new Block(new Position(6, 27)));
            blocks.Add(new Block(new Position(6, 29)));
            blocks.Add(new Block(new Position(6, 31)));
            blocks.Add(new Block(new Position(6, 32)));
            blocks.Add(new Block(new Position(6, 34)));
            blocks.Add(new Block(new Position(6, 36)));
            blocks.Add(new Block(new Position(6, 38)));

            // ROW 7
            blocks.Add(new Block(new Position(7, 6)));
            blocks.Add(new Block(new Position(7, 8)));
            blocks.Add(new Block(new Position(7, 15)));
            blocks.Add(new Block(new Position(7, 17)));
            blocks.Add(new Block(new Position(7, 25)));
            blocks.Add(new Block(new Position(7, 27)));
            blocks.Add(new Block(new Position(7, 34)));
            blocks.Add(new Block(new Position(7, 36)));

            // ROW 8
            blocks.Add(new Block(new Position(8, 2)));
            blocks.Add(new Block(new Position(8, 3)));
            blocks.Add(new Block(new Position(8, 4)));
            blocks.Add(new Block(new Position(8, 8)));
            blocks.Add(new Block(new Position(8, 9)));
            blocks.Add(new Block(new Position(8, 10)));
            blocks.Add(new Block(new Position(8, 11)));
            blocks.Add(new Block(new Position(8, 12)));
            blocks.Add(new Block(new Position(8, 13)));
            blocks.Add(new Block(new Position(8, 17)));
            blocks.Add(new Block(new Position(8, 18)));
            blocks.Add(new Block(new Position(8, 19)));
            blocks.Add(new Block(new Position(8, 21)));
            blocks.Add(new Block(new Position(8, 22)));
            blocks.Add(new Block(new Position(8, 23)));
            blocks.Add(new Block(new Position(8, 27)));
            blocks.Add(new Block(new Position(8, 28)));
            blocks.Add(new Block(new Position(8, 29)));
            blocks.Add(new Block(new Position(8, 30)));
            blocks.Add(new Block(new Position(8, 31)));
            blocks.Add(new Block(new Position(8, 32)));
            blocks.Add(new Block(new Position(8, 36)));
            blocks.Add(new Block(new Position(8, 37)));
            blocks.Add(new Block(new Position(8, 38)));

            // ROW 9
            blocks.Add(new Block(new Position(9, 5)));
            blocks.Add(new Block(new Position(9, 7)));
            blocks.Add(new Block(new Position(9, 14)));
            blocks.Add(new Block(new Position(9, 16)));
            blocks.Add(new Block(new Position(9, 24)));
            blocks.Add(new Block(new Position(9, 26)));
            blocks.Add(new Block(new Position(9, 33)));
            blocks.Add(new Block(new Position(9, 35)));

            // ROW 10
            blocks.Add(new Block(new Position(10, 3)));
            blocks.Add(new Block(new Position(10, 5)));
            blocks.Add(new Block(new Position(10, 9)));
            blocks.Add(new Block(new Position(10, 10)));
            blocks.Add(new Block(new Position(10, 12)));
            blocks.Add(new Block(new Position(10, 14)));
            blocks.Add(new Block(new Position(10, 18)));
            blocks.Add(new Block(new Position(10, 20)));
            blocks.Add(new Block(new Position(10, 22)));
            blocks.Add(new Block(new Position(10, 24)));
            blocks.Add(new Block(new Position(10, 28)));
            blocks.Add(new Block(new Position(10, 29)));
            blocks.Add(new Block(new Position(10, 31)));
            blocks.Add(new Block(new Position(10, 33)));
            blocks.Add(new Block(new Position(10, 37)));

            // ROW 11
            blocks.Add(new Block(new Position(11, 3)));
            blocks.Add(new Block(new Position(11, 7)));
            blocks.Add(new Block(new Position(11, 8)));
            blocks.Add(new Block(new Position(11, 9)));
            blocks.Add(new Block(new Position(11, 12)));
            blocks.Add(new Block(new Position(11, 16)));
            blocks.Add(new Block(new Position(11, 17)));
            blocks.Add(new Block(new Position(11, 18)));
            blocks.Add(new Block(new Position(11, 20)));
            blocks.Add(new Block(new Position(11, 22)));
            blocks.Add(new Block(new Position(11, 26)));
            blocks.Add(new Block(new Position(11, 27)));
            blocks.Add(new Block(new Position(11, 28)));
            blocks.Add(new Block(new Position(11, 31)));
            blocks.Add(new Block(new Position(11, 35)));
            blocks.Add(new Block(new Position(11, 36)));
            blocks.Add(new Block(new Position(11, 37)));
            blocks.Add(new Block(new Position(11, 39)));

            // ROW 12
            blocks.Add(new Block(new Position(12, 3)));
            blocks.Add(new Block(new Position(12, 4)));
            blocks.Add(new Block(new Position(12, 5)));
            blocks.Add(new Block(new Position(12, 9)));
            blocks.Add(new Block(new Position(12, 11)));
            blocks.Add(new Block(new Position(12, 12)));
            blocks.Add(new Block(new Position(12, 13)));
            blocks.Add(new Block(new Position(12, 14)));
            blocks.Add(new Block(new Position(12, 18)));
            blocks.Add(new Block(new Position(12, 20)));
            blocks.Add(new Block(new Position(12, 22)));
            blocks.Add(new Block(new Position(12, 23)));
            blocks.Add(new Block(new Position(12, 24)));
            blocks.Add(new Block(new Position(12, 28)));
            blocks.Add(new Block(new Position(12, 30)));
            blocks.Add(new Block(new Position(12, 31)));
            blocks.Add(new Block(new Position(12, 32)));
            blocks.Add(new Block(new Position(12, 33)));
            blocks.Add(new Block(new Position(12, 37)));

            // ROW 13
            blocks.Add(new Block(new Position(13, 7)));
            blocks.Add(new Block(new Position(13, 9)));
            blocks.Add(new Block(new Position(13, 16)));
            blocks.Add(new Block(new Position(13, 18)));
            blocks.Add(new Block(new Position(13, 22)));
            blocks.Add(new Block(new Position(13, 26)));
            blocks.Add(new Block(new Position(13, 28)));
            blocks.Add(new Block(new Position(13, 35)));
            blocks.Add(new Block(new Position(13, 37)));
            blocks.Add(new Block(new Position(13, 38)));

            // ROW 14
            blocks.Add(new Block(new Position(14, 2)));
            blocks.Add(new Block(new Position(14, 3)));
            blocks.Add(new Block(new Position(14, 4)));
            blocks.Add(new Block(new Position(14, 6)));
            blocks.Add(new Block(new Position(14, 7)));
            blocks.Add(new Block(new Position(14, 11)));
            blocks.Add(new Block(new Position(14, 12)));
            blocks.Add(new Block(new Position(14, 13)));
            blocks.Add(new Block(new Position(14, 15)));
            blocks.Add(new Block(new Position(14, 16)));
            blocks.Add(new Block(new Position(14, 18)));
            blocks.Add(new Block(new Position(14, 20)));
            blocks.Add(new Block(new Position(14, 21)));
            blocks.Add(new Block(new Position(14, 22)));
            blocks.Add(new Block(new Position(14, 23)));
            blocks.Add(new Block(new Position(14, 25)));
            blocks.Add(new Block(new Position(14, 26)));
            blocks.Add(new Block(new Position(14, 30)));
            blocks.Add(new Block(new Position(14, 31)));
            blocks.Add(new Block(new Position(14, 32)));
            blocks.Add(new Block(new Position(14, 34)));
            blocks.Add(new Block(new Position(14, 35)));

            // ROW 15
            blocks.Add(new Block(new Position(15, 6)));
            blocks.Add(new Block(new Position(15, 8)));
            blocks.Add(new Block(new Position(15, 15)));
            blocks.Add(new Block(new Position(15, 22)));
            blocks.Add(new Block(new Position(15, 25)));
            blocks.Add(new Block(new Position(15, 27)));
            blocks.Add(new Block(new Position(15, 34)));
            blocks.Add(new Block(new Position(15, 39)));

            // ROW 16
            blocks.Add(new Block(new Position(16, 3)));
            blocks.Add(new Block(new Position(16, 4)));
            blocks.Add(new Block(new Position(16, 8)));
            blocks.Add(new Block(new Position(16, 10)));
            blocks.Add(new Block(new Position(16, 12)));
            blocks.Add(new Block(new Position(16, 13)));
            blocks.Add(new Block(new Position(16, 16)));
            blocks.Add(new Block(new Position(16, 17)));
            blocks.Add(new Block(new Position(16, 19)));
            blocks.Add(new Block(new Position(16, 20)));
            blocks.Add(new Block(new Position(16, 22)));
            blocks.Add(new Block(new Position(16, 23)));
            blocks.Add(new Block(new Position(16, 27)));
            blocks.Add(new Block(new Position(16, 29)));
            blocks.Add(new Block(new Position(16, 31)));
            blocks.Add(new Block(new Position(16, 32)));
            blocks.Add(new Block(new Position(16, 35)));
            blocks.Add(new Block(new Position(16, 36)));
            blocks.Add(new Block(new Position(16, 38)));

            // ROW 17
            blocks.Add(new Block(new Position(17, 5)));
            blocks.Add(new Block(new Position(17, 10)));
            blocks.Add(new Block(new Position(17, 14)));
            blocks.Add(new Block(new Position(17, 19)));
            blocks.Add(new Block(new Position(17, 24)));
            blocks.Add(new Block(new Position(17, 29)));
            blocks.Add(new Block(new Position(17, 33)));

            // ROW 18
            blocks.Add(new Block(new Position(18, 2)));
            blocks.Add(new Block(new Position(18, 3)));
            blocks.Add(new Block(new Position(18, 5)));
            blocks.Add(new Block(new Position(18, 6)));
            blocks.Add(new Block(new Position(18, 7)));
            blocks.Add(new Block(new Position(18, 8)));
            blocks.Add(new Block(new Position(18, 10)));
            blocks.Add(new Block(new Position(18, 12)));
            blocks.Add(new Block(new Position(18, 14)));
            blocks.Add(new Block(new Position(18, 15)));
            blocks.Add(new Block(new Position(18, 16)));
            blocks.Add(new Block(new Position(18, 17)));
            blocks.Add(new Block(new Position(18, 19)));
            blocks.Add(new Block(new Position(18, 21)));
            blocks.Add(new Block(new Position(18, 22)));
            blocks.Add(new Block(new Position(18, 24)));
            blocks.Add(new Block(new Position(18, 25)));
            blocks.Add(new Block(new Position(18, 26)));
            blocks.Add(new Block(new Position(18, 27)));
            blocks.Add(new Block(new Position(18, 29)));
            blocks.Add(new Block(new Position(18, 31)));
            blocks.Add(new Block(new Position(18, 33)));
            blocks.Add(new Block(new Position(18, 34)));
            blocks.Add(new Block(new Position(18, 35)));
            blocks.Add(new Block(new Position(18, 36)));
            blocks.Add(new Block(new Position(18, 37)));
            blocks.Add(new Block(new Position(18, 38)));

            // ROW 19
            blocks.Add(new Block(new Position(19, 10)));
            blocks.Add(new Block(new Position(19, 19)));
            blocks.Add(new Block(new Position(19, 29)));
            blocks.Add(new Block(new Position(19, 38)));

            // ROW 20
            blocks.Add(new Block(new Position(20, 3)));
            blocks.Add(new Block(new Position(20, 4)));
            blocks.Add(new Block(new Position(20, 6)));
            blocks.Add(new Block(new Position(20, 8)));
            blocks.Add(new Block(new Position(20, 10)));
            blocks.Add(new Block(new Position(20, 12)));
            blocks.Add(new Block(new Position(20, 13)));
            blocks.Add(new Block(new Position(20, 15)));
            blocks.Add(new Block(new Position(20, 17)));
            blocks.Add(new Block(new Position(20, 19)));
            blocks.Add(new Block(new Position(20, 20)));
            blocks.Add(new Block(new Position(20, 22)));
            blocks.Add(new Block(new Position(20, 23)));
            blocks.Add(new Block(new Position(20, 25)));
            blocks.Add(new Block(new Position(20, 27)));
            blocks.Add(new Block(new Position(20, 29)));
            blocks.Add(new Block(new Position(20, 31)));
            blocks.Add(new Block(new Position(20, 32)));
            blocks.Add(new Block(new Position(20, 34)));
            blocks.Add(new Block(new Position(20, 36)));
            blocks.Add(new Block(new Position(20, 38)));

            // ROW 21
            blocks.Add(new Block(new Position(21, 6)));
            blocks.Add(new Block(new Position(21, 8)));
            blocks.Add(new Block(new Position(21, 15)));
            blocks.Add(new Block(new Position(21, 17)));
            blocks.Add(new Block(new Position(21, 22)));
            blocks.Add(new Block(new Position(21, 25)));
            blocks.Add(new Block(new Position(21, 27)));
            blocks.Add(new Block(new Position(21, 34)));
            blocks.Add(new Block(new Position(21, 36)));

            // ROW 22
            blocks.Add(new Block(new Position(22, 2)));
            blocks.Add(new Block(new Position(22, 3)));
            blocks.Add(new Block(new Position(22, 4)));
            blocks.Add(new Block(new Position(22, 8)));
            blocks.Add(new Block(new Position(22, 9)));
            blocks.Add(new Block(new Position(22, 10)));
            blocks.Add(new Block(new Position(22, 11)));
            blocks.Add(new Block(new Position(22, 12)));
            blocks.Add(new Block(new Position(22, 13)));
            blocks.Add(new Block(new Position(22, 17)));
            blocks.Add(new Block(new Position(22, 18)));
            blocks.Add(new Block(new Position(22, 19)));
            blocks.Add(new Block(new Position(22, 21)));
            blocks.Add(new Block(new Position(22, 22)));
            blocks.Add(new Block(new Position(22, 23)));
            blocks.Add(new Block(new Position(22, 27)));
            blocks.Add(new Block(new Position(22, 28)));
            blocks.Add(new Block(new Position(22, 29)));
            blocks.Add(new Block(new Position(22, 30)));
            blocks.Add(new Block(new Position(22, 31)));
            blocks.Add(new Block(new Position(22, 32)));
            blocks.Add(new Block(new Position(22, 36)));
            blocks.Add(new Block(new Position(22, 37)));
            blocks.Add(new Block(new Position(22, 38)));

            // ROW 23
            blocks.Add(new Block(new Position(23, 5)));
            blocks.Add(new Block(new Position(23, 7)));
            blocks.Add(new Block(new Position(23, 14)));
            blocks.Add(new Block(new Position(23, 16)));
            blocks.Add(new Block(new Position(23, 24)));
            blocks.Add(new Block(new Position(23, 26)));
            blocks.Add(new Block(new Position(23, 33)));
            blocks.Add(new Block(new Position(23, 35)));

            // ROW 24
            blocks.Add(new Block(new Position(24, 3)));
            blocks.Add(new Block(new Position(24, 5)));
            blocks.Add(new Block(new Position(24, 9)));
            blocks.Add(new Block(new Position(24, 10)));
            blocks.Add(new Block(new Position(24, 12)));
            blocks.Add(new Block(new Position(24, 14)));
            blocks.Add(new Block(new Position(24, 18)));
            blocks.Add(new Block(new Position(24, 20)));
            blocks.Add(new Block(new Position(24, 21)));
            blocks.Add(new Block(new Position(24, 22)));
            blocks.Add(new Block(new Position(24, 24)));
            blocks.Add(new Block(new Position(24, 28)));
            blocks.Add(new Block(new Position(24, 29)));
            blocks.Add(new Block(new Position(24, 31)));
            blocks.Add(new Block(new Position(24, 33)));
            blocks.Add(new Block(new Position(24, 37)));
            blocks.Add(new Block(new Position(24, 39)));

            // ROW 25
            blocks.Add(new Block(new Position(25, 3)));
            blocks.Add(new Block(new Position(25, 7)));
            blocks.Add(new Block(new Position(25, 8)));
            blocks.Add(new Block(new Position(25, 9)));
            blocks.Add(new Block(new Position(25, 12)));
            blocks.Add(new Block(new Position(25, 16)));
            blocks.Add(new Block(new Position(25, 17)));
            blocks.Add(new Block(new Position(25, 18)));
            blocks.Add(new Block(new Position(25, 22)));
            blocks.Add(new Block(new Position(25, 26)));
            blocks.Add(new Block(new Position(25, 27)));
            blocks.Add(new Block(new Position(25, 28)));
            blocks.Add(new Block(new Position(25, 31)));
            blocks.Add(new Block(new Position(25, 35)));
            blocks.Add(new Block(new Position(25, 36)));
            blocks.Add(new Block(new Position(25, 37)));

            // ROW 26
            blocks.Add(new Block(new Position(26, 3)));
            blocks.Add(new Block(new Position(26, 4)));
            blocks.Add(new Block(new Position(26, 5)));
            blocks.Add(new Block(new Position(26, 9)));
            blocks.Add(new Block(new Position(26, 11)));
            blocks.Add(new Block(new Position(26, 12)));
            blocks.Add(new Block(new Position(26, 13)));
            blocks.Add(new Block(new Position(26, 14)));
            blocks.Add(new Block(new Position(26, 18)));
            blocks.Add(new Block(new Position(26, 19)));
            blocks.Add(new Block(new Position(26, 20)));
            blocks.Add(new Block(new Position(26, 22)));
            blocks.Add(new Block(new Position(26, 23)));
            blocks.Add(new Block(new Position(26, 24)));
            blocks.Add(new Block(new Position(26, 28)));
            blocks.Add(new Block(new Position(26, 30)));
            blocks.Add(new Block(new Position(26, 31)));
            blocks.Add(new Block(new Position(26, 32)));
            blocks.Add(new Block(new Position(26, 33)));
            blocks.Add(new Block(new Position(26, 37)));
            blocks.Add(new Block(new Position(26, 38)));

            // ROW 27
            blocks.Add(new Block(new Position(27, 4)));
            blocks.Add(new Block(new Position(27, 7)));
            blocks.Add(new Block(new Position(27, 9)));
            blocks.Add(new Block(new Position(27, 13)));
            blocks.Add(new Block(new Position(27, 16)));
            blocks.Add(new Block(new Position(27, 18)));
            blocks.Add(new Block(new Position(27, 23)));
            blocks.Add(new Block(new Position(27, 26)));
            blocks.Add(new Block(new Position(27, 28)));
            blocks.Add(new Block(new Position(27, 32)));
            blocks.Add(new Block(new Position(27, 35)));
            blocks.Add(new Block(new Position(27, 37)));

            // ROW 28
            blocks.Add(new Block(new Position(28, 3)));
            blocks.Add(new Block(new Position(28, 4)));
            blocks.Add(new Block(new Position(28, 6)));
            blocks.Add(new Block(new Position(28, 7)));
            blocks.Add(new Block(new Position(28, 12)));
            blocks.Add(new Block(new Position(28, 13)));
            blocks.Add(new Block(new Position(28, 15)));
            blocks.Add(new Block(new Position(28, 16)));
            blocks.Add(new Block(new Position(28, 20)));
            blocks.Add(new Block(new Position(28, 22)));
            blocks.Add(new Block(new Position(28, 23)));
            blocks.Add(new Block(new Position(28, 25)));
            blocks.Add(new Block(new Position(28, 26)));
            blocks.Add(new Block(new Position(28, 31)));
            blocks.Add(new Block(new Position(28, 32)));
            blocks.Add(new Block(new Position(28, 34)));
            blocks.Add(new Block(new Position(28, 37)));
            blocks.Add(new Block(new Position(28, 39)));

            // ROW 29
            blocks.Add(new Block(new Position(29, 6)));
            blocks.Add(new Block(new Position(29, 9)));
            blocks.Add(new Block(new Position(29, 10)));
            blocks.Add(new Block(new Position(29, 15)));
            blocks.Add(new Block(new Position(29, 18)));
            blocks.Add(new Block(new Position(29, 19)));
            blocks.Add(new Block(new Position(29, 20)));
            blocks.Add(new Block(new Position(29, 25)));
            blocks.Add(new Block(new Position(29, 28)));
            blocks.Add(new Block(new Position(29, 29)));
            blocks.Add(new Block(new Position(29, 34)));

            return blocks;
        }
    }
}
