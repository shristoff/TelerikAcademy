using System;

class CountNfactZeroes
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        uint N = uint.Parse(Nstr);
        uint PowersOf5 = 1;
        uint numOfZeroes = 0;
        while (PowersOf5 <= N)
        {
            PowersOf5 = PowersOf5 * 5;
            numOfZeroes = numOfZeroes + N / PowersOf5;
        }
        Console.WriteLine("Number of zeroes in N! = {0}", numOfZeroes);
    }
}
