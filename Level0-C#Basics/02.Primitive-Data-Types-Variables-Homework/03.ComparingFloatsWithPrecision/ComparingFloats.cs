//  Problem 3. Comparing Floats
//  Write a program that safely compares floating-point numbers with precision eps = 0.000001.
//  Note that we cannot directly compare two floating-point numbers a and b by a==b because of 
//  the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if 
//  they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Input first value : ");
        decimal firstValue = decimal.Parse(Console.ReadLine());
        Console.Write("Input second value : ");
        decimal secondValue = decimal.Parse(Console.ReadLine());
        decimal eps = 0.000001m;

        bool compare = Math.Abs(firstValue - secondValue) < eps;

        Console.WriteLine("Both values are equal with precision 0.000001 : {0}", compare);

        // second solution with "if - else" statement

        if (((firstValue - secondValue) >= eps) || ((secondValue - firstValue) >= eps))
        {
            Console.WriteLine("Both values are equal with precision 0.000001 : False");
        }
        else
        {
            Console.WriteLine("Both values are equal with precision 0.000001 : True");
        }
    }
}
