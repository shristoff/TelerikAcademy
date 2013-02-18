/* We are given 5 integer numbers. Write a program that 
 checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0. */

using System;

 class ZeroSumSubsetCheck
 {
     static int n1 = 5;
     static int n2 = -2;
     static int n3 = 6;
     static int n4 = 2;
     static int n5 = -13;

     static void ZeroSum2(int a, int b)
     {
         if ((a + b) == 0)
         {
             Console.WriteLine("One zero sum subnet is ({0}) + ({1}) = 0", a, b);
         }
     }

     static void ZeroSum3(int a, int b, int c)
     {
         if ((a + b + c) == 0)
         {
             Console.WriteLine("One zero sum subnet is ({0}) + ({1}) + ({2})= 0", a, b, c);
         }
     }

     static void ZeroSum4(int a, int b, int c, int d)
     {
         if ((a + b + c + d) == 0)
         {
             Console.WriteLine("One zero sum subnet is ({0}) + ({1}) + ({2}) + ({3}) = 0", a, b, c, d);
         }
     }

     static void Main()
     {
         if ((n1 == 0) || (n2 == 0) || (n3 == 0) || (n4 == 0) || (n5 == 0))
         {
             Console.WriteLine("There is zero sum subset - one of the numbers is zero");
         }
         if ((n1 + n2 + n3 + n4 + n5) == 0)
         {
             Console.WriteLine("One zero sum subnet is ({0}) + ({1}) + ({2}) + ({3}) + ({4}) = 0", n1, n2, n3, n4, n5);
         }
         ZeroSum2(n1, n2);
         ZeroSum2(n1, n3);
         ZeroSum2(n1, n4);
         ZeroSum2(n1, n5);
         ZeroSum2(n2, n3);
         ZeroSum2(n2, n4);
         ZeroSum2(n2, n5);
         ZeroSum2(n3, n4);
         ZeroSum2(n3, n5);
         ZeroSum2(n4, n5);
         ZeroSum3(n1, n2, n3);
         ZeroSum3(n1, n2, n4);
         ZeroSum3(n1, n2, n5);
         ZeroSum3(n1, n3, n4);
         ZeroSum3(n1, n3, n5);
         ZeroSum3(n1, n4, n5);
         ZeroSum3(n2, n3, n4);
         ZeroSum3(n2, n3, n5);
         ZeroSum3(n2, n4, n5);
         ZeroSum3(n3, n4, n5);
         ZeroSum4(n1, n2, n3, n4);
         ZeroSum4(n1, n2, n3, n5);
         ZeroSum4(n1, n2, n4, n5);
         ZeroSum4(n1, n3, n4, n5);
         ZeroSum4(n2, n3, n4, n5);
     }
 }

