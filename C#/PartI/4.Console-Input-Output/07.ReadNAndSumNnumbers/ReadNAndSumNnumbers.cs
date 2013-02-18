using System;

class ReadNAndSumNnumbers
{
    static void Main()
    {
        Console.Write("Please enter positive integer number n = ");
        string nstr = Console.ReadLine();
        int n = int.Parse(nstr);
        int i = 1;
        int sum = 0;
        while (i <= n)
        {
            Console.Write("Please enter an integer n{0} = ", i);
            string nistr = Console.ReadLine();
            int ni = int.Parse(nistr);
            i++;
            sum = sum + ni;
        }
        Console.WriteLine("The sum of all the n numbers is: {0}", sum);
    }
}
