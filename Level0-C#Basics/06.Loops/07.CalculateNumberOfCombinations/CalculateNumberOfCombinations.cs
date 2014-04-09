//  Problem 7. Calculate N! / (K! * (N-K)!)
//  In combinatorics, the number of ways to choose k different members 
//  out of a group of n different elements (also known as the number of combinations) 
//  is calculated by the following formula: (K from N) = N! / (K! * (N-K)!)
//  For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
//  Your task is to write a program that calculates n! / (k! * (n-k)!) 
//  for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class CalculateNumberOfCombinations
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;
        if (K > 1 && N > K && N < 100)
        {

            for (int i = 1; i <= N; i++)            // if (1 < k < n) => k will be in this loop
            {
                factorialN *= i;
                if (i == K)
                {
                    factorialK *= factorialN;
                }
            }
            for (int i = 1; i <= N - K; i++)
            {
                factorialNK *= i;
            }
            BigInteger result = factorialN / (factorialK * factorialNK);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("NO RESULT");
        }
    }
}

