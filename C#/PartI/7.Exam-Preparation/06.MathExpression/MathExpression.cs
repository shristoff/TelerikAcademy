/* Your task is to write a computer program that calculates the result from the shown mathematical expression, 
 depending on the values of the variables N, M and P.*/

using System;

class MathExpression
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        double N = double.Parse(Nstr);
        string Mstr = Console.ReadLine();
        double M = double.Parse(Mstr);
        string Pstr = Console.ReadLine();
        double P = double.Parse(Pstr);
        double MathExpr = (N * N + ((1 / M) * (1 / P)) + 1337) / (N - (128.523123123 * P)) + Math.Sin((int)(M % 180));
        Console.WriteLine("{0:0.000000}", MathExpr);
    }
}