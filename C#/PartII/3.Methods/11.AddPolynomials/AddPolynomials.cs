/* Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5  */

using System;

public class AddPolynomials
{
    public static int[] ReadAndSumPolynomialsCoeff(int[] poly1, int[] poly2, int[] sum)
    {
        for (int i = poly1.Length - 1; i >= 0; i--)
		{
	        poly1[i] = int.Parse(Console.ReadLine());
            poly2[i] = int.Parse(Console.ReadLine());
            sum[i] = poly1[i] + poly2[i];
        }
        return sum;
    }

    public static void PrintPolynomial(int[] sum)
    {
        string sumToString = "";
        bool firstDifFrom0 = true;
        for (int i = sum.Length - 1; i >= 0; i--)
        {
            switch (sum[i])
            {
                case -1: switch (i)
                    {
                        case 1: sumToString = "-x"; break;
                        case 0: sumToString = sum[i].ToString(); break;
                        default: sumToString = "-x^" + i; break;
                    } break;
                case 0: continue;
                case 1: switch (i)
                    {
                        case 1: sumToString = "+x"; break;
                        case 0: sumToString = "+" + sum[i].ToString(); break;
                        default: if (firstDifFrom0)
                                sumToString = "x^" + i;
                            else
                                sumToString = "+x^" + i;
                            break;
                    } break;
                default: if (sum[i] < 0 || firstDifFrom0)
                        {
                            switch (i)
                            {
                                case 1: sumToString = sum[i].ToString() + "x"; break;
                                case 0: sumToString = sum[i].ToString(); break;
                                default: sumToString = sum[i].ToString() + "x^" + i; break;
                            }
                        }
                        if (sum[i] > 0 && !firstDifFrom0)
                        {
                            switch (i)
                            {
                                case 1: sumToString = "+" + sum[i].ToString() + "x"; break;
                                case 0: sumToString = "+" + sum[i].ToString(); break;
                                default: sumToString = "+" + sum[i].ToString() + "x^" + i; break;
                            }
                        } break;
                    }
            Console.Write(sumToString);
            firstDifFrom0 = false;
            }
            Console.WriteLine();
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the highest power of the polynomial with bigger power: ");
        int power = int.Parse(Console.ReadLine());
        int[] poly1 = new int[power + 1];
        int[] poly2 = new int[power + 1];
        int[] sum = new int[power + 1];
        Console.WriteLine("Please enter the coefficients starting of the highest power of the first polynomial then of the second polynomial (include 0 coefficients): ");
        sum = ReadAndSumPolynomialsCoeff(poly1, poly2, sum);
        Console.Write("Polinomial 1:  "); 
        PrintPolynomial(poly1);
        Console.Write("Polinomial 2:  "); 
        PrintPolynomial(poly2);
        Console.Write("Their sum is:  "); 
        PrintPolynomial(sum);
        Console.WriteLine();
    }
}