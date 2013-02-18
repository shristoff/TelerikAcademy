/*Write a program that shows the sign (+ or -) of the product 
 of three real numbers without calculating it. Use a sequence of if statements.*/

using System;

class ProductOf3NumsSign
{
    static void Main()
    {
        float a = 5.34f;
        float b = 2.12f;
        float c = 0f;
        if (((a > 0) ^ (b > 0)) && (c > 0)) //a i b s razlichni znaci i c>0
        {
            Console.WriteLine("Product sign is minus");
        }
        else if (!((a > 0) ^ (b > 0)) && (c > 0)) //a i b s ednakvi znaci  i c>0
        {
            Console.WriteLine("Product sign is plus"); 
        }
        else if (((a > 0) ^ (b > 0)) && (c < 0)) // a i b s razlichni znaci i c<0
        {
            Console.WriteLine("Product sign is plus"); 
        }
        else if (!((a > 0) ^ (b > 0)) && (c < 0)) //a i b s ednakvi znaci  i c<0
        {
            Console.WriteLine("Product sign is minus");
        }
        else if ((a==0) || (b==0) || (c==0))
        {
            Console.WriteLine("Product is zero");
        }
    }
}