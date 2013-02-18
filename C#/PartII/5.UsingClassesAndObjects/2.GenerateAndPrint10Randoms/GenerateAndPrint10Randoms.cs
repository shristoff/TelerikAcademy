/* Write a program that generates and prints to the console 10 random values in the range [100, 200]. */

using System;

class GenerateAndPrint10Randoms
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int i = 0;
        while (i < 10)
        {
            int randomNumber = randomGenerator.Next(100, 201);
            Console.WriteLine(randomNumber);
            System.Threading.Thread.Sleep(200);
            i++;
        }
    }
}
