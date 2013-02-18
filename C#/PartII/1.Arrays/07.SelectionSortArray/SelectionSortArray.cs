/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
find the smallest from the rest, move it at the second position, etc.*/

using System;

class SelectionSortArray
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array N:");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        int[] Arr = new int[N];
        int i = 0, j = 0, count = 0, temp;
        bool smallest = false;
        while (i < N)
        {
            Console.WriteLine("Please enter the {0} number of the array", i + 1);
            string Numstr = Console.ReadLine();
            Arr[i] = int.Parse(Numstr);
            i++;
        }
        for (i = 0; i < N; i++)
        {
            for (j = 0 + count; j < N; j++)   //count broi kolko nai-malki elementa sa namereni do momenta, 
            {                                 //dobavqme kym j, za da proverqva samo ostanalite
                smallest = Arr[i] <= Arr[j];     //booleva promenliva smallest, koqto e false do namiraneto na nai-malyk element
                if (!smallest)           //ako namerim po-golqm ot proverqvaniq element (smallest = false) 
                    break;               //izlizame ot vytreshniq cikyl, za da ne se vyrti bez nujda
            }
            if (smallest)                  //ako ne sme namerili po-malyk element ot proverqvaniq (smallest = true)
            {
                temp = Arr[count];         //razmenqme proverqvaniq s pyrviq element Arr[0]
                Arr[count] = Arr[i];
                Arr[i] = temp;
                count++;            //uvelichavame count s 1 za vseki nameren nai-malyk element
                i = count - 1;     //naglasqme osnovniq broqch, taka che da ne proverqva veche sortiranite elementi
            }
        }
        i = 0;
        foreach (var item in Arr)
        {
            Console.Write("{0} ", Arr[i]);
            i++;
        }
    }
}