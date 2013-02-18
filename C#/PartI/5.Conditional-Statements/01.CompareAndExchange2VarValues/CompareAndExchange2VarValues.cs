/*Write an if statement that examines two integer variables and exchanges 
their values if the first one is greater than the second one.*/

using System;

class CompareAndExchange2VarValues
{
    static void Main()
    {
        int a = 5;
        int b = 2;
        if (a > b)
        {
            a = a + b; 
            b = a - b; 
            a = a - b;
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
        else 
        {
            Console.WriteLine("a < b");
        }
    }
}