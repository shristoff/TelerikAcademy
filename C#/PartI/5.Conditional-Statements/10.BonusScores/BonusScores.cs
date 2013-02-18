/*Write a program that applies bonus scores to given scores in the range [1..9]. 
The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
If it is zero or if the value is not a digit, the program must report an error.
Use a switch statement and at the end print the calculated new value in the console.*/

using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Please enter digit for score between 1 and 9: ");
        int Score = int.Parse(Console.ReadLine());
        switch (Score)
        {
            case 1:
            case 2:
            case 3:
                Score = Score * 10;
                Console.WriteLine("Bonus Score = {0}", Score);
                break;
            case 4:
            case 5:
            case 6:
                Score = Score * 100;
                Console.WriteLine("Bonus Score = {0}", Score);
                break;
            case 7:
            case 8:
            case 9:
                Score = Score * 1000;
                Console.WriteLine("Bonus Score = {0}", Score);
                break;
        }
    }
}
