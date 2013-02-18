using System;

class QuotedStrings
{
    static void Main()
    {
        string nq = "The \"use\" of quotations causes difficulties.";
        string q = @"The ""use"" of quotations causes difficulties.";  //string quoted using @
        Console.WriteLine(q + '\n' + nq);
    }
}
