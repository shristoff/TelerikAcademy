using System;

class NullValues
{
    static void Main()
    {
        int? iNull = null;
        double? dNull = null;
        Console.WriteLine(iNull);
        Console.WriteLine(dNull);
        iNull = 5;
        dNull = 2.343434d;
        iNull = 5 + null;
        dNull = 2.343434d + null;
        Console.WriteLine(iNull);
        Console.WriteLine(dNull);
    }
}