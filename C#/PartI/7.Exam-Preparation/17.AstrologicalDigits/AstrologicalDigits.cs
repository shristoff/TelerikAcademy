/*The astrological digit of a given number N is a digit calculated by the number's digits 
 by a special algorithm. The algorithm performs the following steps:
(1)	Sums the digits of the number N and stores the result back in N.
(2)	If the obtained result is bigger than 9, step (1) is repeated, otherwise the algorithm finishes.
The last obtained value of N is the result, calculated by the algorithm.*/

using System;

class AstrologicalDigits
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        int i = 0;
        int sum = 0;
        while (i < Nstr.Length)
        { 
            string digit = Nstr.Substring(i,1);
            if (digit != "." && digit != "-")
                sum = sum + int.Parse(digit);
            if (sum >= 10 && i == Nstr.Length - 1)
            {
                Nstr = Convert.ToString(sum);
                i = -1;
                sum = 0;
            }
            i++;
        }
        Console.WriteLine(sum);
    }
}