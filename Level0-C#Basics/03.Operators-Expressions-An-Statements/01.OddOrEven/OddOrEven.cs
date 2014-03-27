//  Problem 1. Odd or Even Integers
//  Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter integer value n = ");
        int intValue = int.Parse(Console.ReadLine());

        bool result = (intValue % 2) != 0;
        Console.WriteLine("Integer n is Odd? - {0}", result);
    }
}

