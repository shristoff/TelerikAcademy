/* Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm */

using System;

class PrimeNumbersTo10mln
{
    static void Main()
    {
        int i = 2, j = 2, count = 0;
        bool[] composites = new bool[10000001];  //декларираме булев масив, в който маркираме съставните числа
        for (j = 2; j * j < composites.Length;)  //на всяка итерация j става равно на следващото просто число (ред 19-20)
        {                                           //докато квадрата на това число е по-малък от 10 млн
            while (i + j <= composites.Length - 1)  //докато индексът е в границите на масива
            {                                       //прибавяме към всяко просто число себе си докато не стигнем 10 млн
                i = i + j;                          //получените числа ги маркираме като съставни, защото са кратни на простото число
                composites[i] = true;               //добавено много на брой пъти към себе си
            }
            j++;                                    //увеличаваме j докато не стигнем следващото просто число
            if (!composites[j])                     //когато достигнем някое, немаркирано като съставно, число
                i = j;                              //i става равно на това просто число
        }
        for (i = 0; i < composites.Length; i++)
        {
            if (!composites[i] && i > 1)        //ако числото е немаркирано и е по-голямо от 1
            {
                count++;                    //увеличаваме брояча на простите числа с 1
                Console.Write(i + " ");      //печатаме
            }
        }
        Console.WriteLine("Number of prime numbers is: {0}", count);
    }
}

/*
1. Create a list of consecutive integers from 2 to n: (2, 3, 4, ..., n).
2. Initially, let p equal 2, the first prime number.
3. Starting from p, count up in increments of p and mark each of these numbers 
   greater than p itself in the list. These will be multiples of p: 2p, 3p, 4p, etc.; 
   note that some of them may have already been marked.
4. Find the first number greater than p in the list that is not marked. 
  If there was no such number, stop. Otherwise, let p now equal this number 
  (which is the next prime), and repeat from step 3.
*/