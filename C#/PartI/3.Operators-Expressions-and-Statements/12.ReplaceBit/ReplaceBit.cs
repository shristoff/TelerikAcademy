using System;

class ReplaceBit
{
    static void Main()
    {
        Console.Write("Please enter an integer number n = ");   
        int n = int.Parse(Console.ReadLine());                  
        Console.WriteLine("The binary format of n is: {0}", Convert.ToString(n,2));
        Console.Write("Please enter bit position p = ");        
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter new bit (0 or 1) v = ");    
        int v = int.Parse(Console.ReadLine());
        int new_n = (v == 0 ? (~(1 << p) & n) : ((1 << p) | n));
        string new_n2 = Convert.ToString(new_n,2);
        Console.WriteLine("The new bit at position {0} is {1} and the new number is {2} = {3} in binary format", p, v, new_n, new_n2); 
    }
}