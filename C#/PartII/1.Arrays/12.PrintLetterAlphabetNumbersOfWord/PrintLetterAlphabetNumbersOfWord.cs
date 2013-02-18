/*Write a program that creates an array containing all letters from the alphabet (A-Z). 
Read a word from the console and print the index of each of its letters in the array.*/

using System;

class PrintLetterAlphabetNumbersOfWord
{
    static void Main()
    {
        int i, start = 0, end, delta, index;
        int[] Alphabet = new int[26];
        end = Alphabet.Length - 1;               //краят на интервала в който търсим елемента е равен на последния индекс на масива
        Console.WriteLine("Please write a word: ");
        string word = Console.ReadLine();
        int[] Word = new int[word.Length];
        for (i = 0; i < Alphabet.Length; i++)
        {
            Alphabet[i] = 'a' + i;    //създаваме масив с буквите на азбуката
            if (i < word.Length)
                Word[i] = Convert.ToChar(word.Substring(i, 1));   //създаваме масив с буквите на думата
        }
        for (i = 0; i < Word.Length; i++)
        {
        do
            {
                delta = (end - start) / 2;     //делта е половината интервал - ще я добавяме към по-далечния от елемента край на интервала
                if (delta == 0)        //заради целочисленото деление, с което получаваме делта, тя става 0 една итерация преди да сме свили интервала 
                    delta = 1;                  //(start = end) затова, когато стане 0 й даваме пак стойност 1, N > 1, защото при масив от 1 елемент index става 1;
                index = start + delta;          //средният индекс е равен на началото на интервала + половината на интервала
                if (Word[i] < Alphabet[index]) //ако търсеният елемент е по-малък от средния елемент разглеждаме първата половина на масива
                    end = end - delta;              //краят на първата половина на новия интервал е краят на стария интервал минус половината стар интервал
                else
                    start = start + delta;         //ако търсеният елемент е във втората половина на интервала към началото на интервала добавяме половината интервал,
            }                                       //с което изместваме началото на новия интервал в средата на стария
            while (start != end);                   //въртим цикъла докато началото и краят на интервала не станат равни, когато станат равни
        Console.Write(" {0}", start);
        end = Alphabet.Length - 1;    //връщаме началните стойности на началото и края на интервала след всяко изпълнение на цикъла
        start = 0;
        }
        Console.Write(";\n");
    }
}