using System;

class AngryBits
{
    static void Main()
    {
        int[,] numbers = new int[9, 17];
        int row, col, rowcol8, rowtemp, pigs = 0, rowpigs, colpigs, flight, score;
        for (row = 0; row < 8; row++)
        {
            string Numstr = Console.ReadLine();
            numbers[row, 16] = ushort.Parse(Numstr);
            for (col = 0; col < 16; col++)
            {
                numbers[row, col] = (numbers[row, 16] >> col) & 1;
            }
        }
        while (row > 0)
        {
            row = 7;
            col = 7;
            {
                if (numbers[row - 1, col] == 1)
                {
                    for (rowpigs = -1; rowpigs <= 1; rowpigs++)
                    {
                        for (colpigs = -1; colpigs <= 1; colpigs++)
                        {
                            if (numbers[row - 1 + rowpigs, col + colpigs] == 1)
                                pigs++;
                        }
                    }
                }
                score = pigs;
                numbers[row, 8] = 0;
            }
            row--;
            col--;
        }


        //if (numbers[row, col] == 1 && numbers[7 - row, 8] == 0)
        //    numbers[7 - row, 8] = 1;
    }
}

