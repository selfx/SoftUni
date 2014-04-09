//  Problem 6. Calculate N! / K!
//  Write a program that calculates n! / k! for given 
//  n and k (1 < k < n < 100). Use only one loop.

using System;

class DivideFactorials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long factirialN = 1;
        long factirialK = 1;
        for (int i = 2; i <= n; i++)
        {
            factirialN *= i;
            if (i == k)
            {
                factirialK *= factirialN;
            }
        }
        long result = factirialN / factirialK;
        Console.WriteLine(result);
    }
}
