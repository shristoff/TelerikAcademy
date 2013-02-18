/* Given five positive integers, their least majority multiple is the smallest positive integer 
 that is divisible by at least three of them. Your task is to write a program that for 
 given distinct integers a, b, c, d and e, returns their least majority multiple.*/

using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        string astr = Console.ReadLine();
        int a = int.Parse(astr);
        string bstr = Console.ReadLine();
        int b = int.Parse(bstr);
        string cstr = Console.ReadLine();
        int c = int.Parse(cstr);
        string dstr = Console.ReadLine();
        int d = int.Parse(dstr);
        string estr = Console.ReadLine();
        int e = int.Parse(estr);
        int[,] InputNums = { { a, b, c }, { a, b, d }, { a, b, e }, { a, c, d }, { a, c, e }, 
                              { a, d, e }, { b, c, d }, { b, c, e }, { b, d, e }, { c, d, e } };
        int LCM = 1;
        int MinLCM = 1000000;
        byte i = 0;
        byte row = 0;
        byte[] PrimeNums = new byte[25] { 2, 3, 5, 7, 11, 13, 17, 19, 23,
            29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        bool FirstRemainder0;
        bool SecondRemainder0;
        bool ThirdRemainder0;
        for (row = 0; row < 10; row++)
        {
            for (i = 0; i < 25; i++)
            {
                do
                {
                    FirstRemainder0 = InputNums[row, 0] % PrimeNums[i] == 0;
                    SecondRemainder0 = InputNums[row, 1] % PrimeNums[i] == 0;
                    ThirdRemainder0 = InputNums[row, 2] % PrimeNums[i] == 0;
                    if (FirstRemainder0)
                    {
                        InputNums[row, 0] = InputNums[row, 0] / PrimeNums[i];
                    }
                    if (SecondRemainder0)
                    {
                        InputNums[row, 1] = InputNums[row, 1] / PrimeNums[i];
                    }
                    if (ThirdRemainder0)
                    {
                        InputNums[row, 2] = InputNums[row, 2] / PrimeNums[i];
                    }
                    if (FirstRemainder0 || SecondRemainder0 || ThirdRemainder0)
                        LCM = LCM * PrimeNums[i];
                    FirstRemainder0 = InputNums[row, 0] % PrimeNums[i] == 0;
                    SecondRemainder0 = InputNums[row, 1] % PrimeNums[i] == 0;
                    ThirdRemainder0 = InputNums[row, 2] % PrimeNums[i] == 0;
                }
                while (FirstRemainder0 || SecondRemainder0 || ThirdRemainder0);
                if (InputNums[row, 0] == 1 && InputNums[row, 1] == 1 && InputNums[row, 2] == 1)
                    break;
            }
            if (MinLCM > LCM)
                MinLCM = LCM;
            LCM = 1;
        }
        Console.WriteLine(MinLCM);
    }
}