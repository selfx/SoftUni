//  FactorialProblem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//  Write a program that, for a given two integer numbers n and x, 
//  calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. 
//  Print the result with 5 digits after the decimal point.

using System;

class CalculateFactorialsInSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double factirial = 1;
        double result  = 0; 
        for (double i = 1; i <= n; i++)
        {
            factirial *= i;
            double singleValue = factirial / (Math.Pow(x, i)); 
            result += singleValue;
        }
        Console.WriteLine("{0:F5}", (1 + result));
    }
}

