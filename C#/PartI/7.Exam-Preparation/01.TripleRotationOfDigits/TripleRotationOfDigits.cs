using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        string Kstr = Console.ReadLine();
        int K = int.Parse(Kstr);
        int Num1 = (int)Math.Pow(10, Kstr.Length - 1) * (K % 10) + (K / 10);
        int Num2 = (int)Math.Pow(10, Convert.ToString(Num1).Length - 1) * (Num1 % 10) + (Num1 / 10);
        int Num3 = (int)Math.Pow(10, Convert.ToString(Num2).Length - 1) * (Num2 % 10) + (Num2 / 10);
        Console.WriteLine(Num3);
     }
}
