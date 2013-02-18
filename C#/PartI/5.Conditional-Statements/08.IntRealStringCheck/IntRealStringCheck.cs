/*Write a program that, depending on the user's choice inputs int, double or string variable.
If the variable is integer or double, increases it with 1. 
If the variable is string, appends "*" at its end. 
The program must show the value of that variable as a console output. Use switch statement. */

using System;
using System.Threading;
using System.Globalization;

class IntRealStringCheck
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter 0 for integer, 1 for real number and 2 for string: ");
        int InputType = int.Parse(Console.ReadLine());
        switch (InputType)
        { 
            case 0:
                Console.Write("Please enter an integer number: i = ");
                int i = int.Parse(Console.ReadLine());
                i = i + 1;
                Console.WriteLine(i);
                break;
            case 1:
                Console.Write("Please enter a real number: r = ");
                float r = float.Parse(Console.ReadLine());
                r = r + 1.0f;
                Console.WriteLine(r);
                break;
            case 2:
                Console.Write("Please enter a string: str = ");
                string str = Console.ReadLine();
                str = str + "*";
                Console.WriteLine(str);
                break;
        }
    }
}
