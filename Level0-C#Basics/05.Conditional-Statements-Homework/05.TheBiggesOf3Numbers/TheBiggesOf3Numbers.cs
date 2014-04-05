//  Problem 5. The Biggest of 3 Numbers
//  Write a program that finds the biggest of three numbers.

using System;

class TheBiggesOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number c = ");
        double c = double.Parse(Console.ReadLine());
        double? result = null;
        if ((a > b))
        {
            if (a > c)
            {
                result = a;
            }
            else
            {
                result = c;
            }
        }
        else if (b > c)
            {
                result = b;
            }
        else
        {
            result = c;
        }
        Console.WriteLine("biggest " + result);
    }
}

