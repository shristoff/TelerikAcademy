/*You are given N positive integer numbers that are converted to binary numeral system and are concatenated together 
 in one big sequence of bits. For example: if we have 4 numbers: 5 (101 in binary numeral system), 6 (110 in binary numeral system),
14 (1110 in binary numeral system) and 143 (10001111 in binary numeral system) their concatenation will be 101110111010001111.
You are also given a positive integer K - the number of identical bits (zeroes or ones that can dance together).
Write a program that finds the number of all “dancing bits” (the sequences of equal bits) with a length of exactly K bits.
Your program should search in the concatenation of the given N numbers. For example, if we have 4 numbers (5, 6, 14 and 143, 
the concatenation of their binary representation is 101110111010001111) and we are searching for the total number of 
all sequences of equal bits with an exact length of 3 bits, the answer will be 3 (the sequences are bolded in the concatenation above).
In this example we have two sequences of “dancing bits” - "111" consisting of only ones and one sequence of “dancing bits” - "000" 
consisting of only zeros. Note that the sequence "1111" is not a sequence of exact 3 identical bits.*/

using System;

class DancingBits
{
    static void Main()
    {
        string Kstr = Console.ReadLine();
        int K = int.Parse(Kstr);
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        int number;
        int index = 0;
        int count = 1;
        int seq = 0;
        int seqNumber = 0;
        string sequence = "", digit0, digit1;
        while (index < N)
        {
            string Numstr = Console.ReadLine();
            number = int.Parse(Numstr);
            sequence = sequence + Convert.ToString(number, 2);
            index++;
        }
        sequence = sequence + " ";
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            digit0 = sequence.Substring(i, 1);
            digit1 = sequence.Substring(i + 1, 1);
            if (digit0 == digit1)
                count++;
            else
            {
                seq = count;
                count = 1;
            }
            if (seq == K)
            {
                seqNumber++;
                seq = 0;
            }
        }
        Console.WriteLine(seqNumber);
    }
}