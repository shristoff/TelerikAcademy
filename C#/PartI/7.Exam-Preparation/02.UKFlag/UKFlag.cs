using System;

class Program
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        for (int j = 0; j <= (N / 2 - 1); j++)
        {
            string Right = new String('.', N/2 - 1 - j);
            string Left = new String('.', j);
            Console.WriteLine(Left + '\\' + Right + '|' + Right + '/' + Left);
        }
        string Middle = new String('-', N / 2);
        Console.WriteLine(Middle + '*' + Middle);
        for (int j = (N / 2 - 1); j >= 0; j--)
        {
            string Right = new String('.', N / 2 - 1 - j);
            string Left = new String('.', j);
            Console.WriteLine(Left + '/' + Right + '|' + Right + '\\' + Left);
        }
    }
}
