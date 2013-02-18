/* Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.*/

using System;

class CalcMinMaxAverSumProduct
{
    static int Minimum(params int[] arr)
    {
        int minNum = 0;
        bool smallest = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                smallest = arr[i] <= arr[j];
                if (!smallest)              
                    break;               
            }
            if (smallest)                
                minNum = arr[i];         
        }
        return minNum;
    }

    static int Maximum (params int[] arr)
    {
        int maxNum = 0;
        bool biggest = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)   
            {                                  
                biggest = arr[i] >= arr[j];  //булева промелнива biggest, която е със стойност false до намирането на 
                if (!biggest)               //най-големия елемент, ако намерим по-голям от проверявания елемент (biggest = false) 
                    break;               //излизаме от вътрешния цикъл, за да не се върти без нужда
            }
            if (biggest)                //ако не сме намерили по-голям от проверявание елемент  (biggest = true)
                maxNum = arr[i];         //записваме стойността в maxNum
        }
        return maxNum;
    }

    static decimal Average(params decimal[] arr)
    {
        int i = 0;
        decimal sum = 0, average = 0;
        while (i < arr.Length)
        {
            sum = sum + arr[i];
            i++;
        }
        average = (decimal)(sum / arr.Length);
        return average;
    }

    static int Sum(params int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
            sum = sum + num;
        return sum;
    }

    static long Product(params int[] arr)
    {
        long product = 1;
        foreach (int num in arr)
            product = product*num;
        return product;
    }

    static void Main()
    {
        Console.WriteLine("\n Minimum is: {0}", Minimum(0, 1, 34, -12, 3, 9, 1));
        Console.WriteLine(" Maximum is: {0}", Maximum(18, -12, 724, -12, 3, 9, 1, 123));
        Console.WriteLine(" Average is: {0}", Average(20, 120, -34, -12, 321, 9, 1, 123, 45, 64, 23, 129, 9430, -1234));
        Console.WriteLine(" The Sum is: {0}", Sum(4, 1, 34, -12, 3, 9, 1, 398, -234, 1));
        Console.WriteLine(" Product is: {0}\n", Product(78, 1, 24));
    }
}