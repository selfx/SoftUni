//  Problem 8. Catalan Numbers
//  In combinatorics, the Catalan numbers are calculated by the Catalan formula:
//  C(n) = (2n)! / (n+1)!*n!
//  Write a program to calculate the nth Catalan number by given n (1 < n < 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger facN = 1;
        BigInteger facNp1 = 1;
        BigInteger fac2N = 1;
        for (int i = 1; i <= (2 * n) ; i++)
        {
            fac2N *= i;            
            if (i == (n))
            {
                facN = fac2N;
            }
            if (i == (n + 1))
            {
                facNp1 = fac2N;
            }           
        }
        BigInteger result = fac2N / (facNp1 * facN);
        Console.WriteLine(result);
    }
}

