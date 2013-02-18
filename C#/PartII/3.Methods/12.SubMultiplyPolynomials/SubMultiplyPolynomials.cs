/* Extend the program to support also subtraction and multiplication of polynomials. */

using System;

public class SubMultiplyPolynomials
{
    static int[] ReadAndSubPolynomialsCoeff(int[] poly1, int[] poly2, int[] sub)
    {
        for (int i = poly1.Length - 1; i >= 0; i--)
        {
            poly1[i] = int.Parse(Console.ReadLine());
            poly2[i] = int.Parse(Console.ReadLine());
            sub[i] = poly1[i] - poly2[i];
        }
        return sub;
    }

    static int[] MultiplyPolynomials(int[] poly1, int[] poly2, int[] product)
    {
        int productIndex;
        for (int i = 0; i < poly1.Length; i++)
        {
            for (int j = 0; j < poly2.Length; j++)
            {
                productIndex = i + j;
                product[productIndex] = product[productIndex] + (poly1[i] * poly2[j]);
            }
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the highest power of the polynomial with bigger power: ");
        int power = int.Parse(Console.ReadLine());
        int[] poly1 = new int[power + 1];
        int[] poly2 = new int[power + 1];
        int[] sub = new int[power + 1];
        int[] product = new int[2 * power + 1];
        Console.WriteLine("Please enter the coefficients starting of the highest power of the first polynomial then of the second polynomial (include 0 coefficients): ");
        sub = ReadAndSubPolynomialsCoeff(poly1, poly2, sub);
        product = MultiplyPolynomials(poly1, poly2, product);
        Console.Write("Polinomial 1:  ");
        AddPolynomials.PrintPolynomial(poly1);
        Console.Write("Polinomial 2:  ");
        AddPolynomials.PrintPolynomial(poly2);
        Console.Write("Substraction:  ");
        AddPolynomials.PrintPolynomial(sub);
        Console.Write("TheirProduct:  ");
        AddPolynomials.PrintPolynomial(product);
        Console.WriteLine();
    }
}