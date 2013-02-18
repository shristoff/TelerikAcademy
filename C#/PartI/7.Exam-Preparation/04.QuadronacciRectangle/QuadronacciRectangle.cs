using System;
using System.Numerics;

class QuadronacciRectangle
{
    static void Main()
    {
        string strn1 = Console.ReadLine();
        BigInteger n1 = BigInteger.Parse(strn1);
        string strn2 = Console.ReadLine();
        BigInteger n2 = BigInteger.Parse(strn2);
        string strn3 = Console.ReadLine();
        BigInteger n3 = BigInteger.Parse(strn3);
        string strn4 = Console.ReadLine();
        BigInteger n4 = BigInteger.Parse(strn4);
        string strR = Console.ReadLine();
        int R = int.Parse(strR);
        string strC = Console.ReadLine();
        int C = int.Parse(strC);
        BigInteger sum = 0;
        if (C == 4)
            Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3, n4);
        if (C > 4)
            Console.Write("{0} {1} {2} {3} ", n1, n2, n3, n4);
        for (int i = 0; i < (R*C) - 4; i++)
        {
            sum = n1 + n2 + n3 + n4;
            n1 = n2;
            n2 = n3;
            n3 = n4;
            n4 = sum;
            if ((i + 4) % C == 0 && i > 0)
                Console.WriteLine();
            if ((i + 5) % C == 0 && i > C)
                Console.Write(sum);
            else
                Console.Write(sum + " ");
        }
    }
}