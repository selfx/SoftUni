//  Problem 9. Sum of n Numbers
//  Write a program that enters a number n and after that enters
//  more n numbers and calculates and prints their sum. 
//  Note that you may need to use a for-loop.

using System;

class SumOfNumbersN
{
    static void Main()
    {
        Console.Write("Enter number (n>0) n = ");
        int n = int.Parse(Console.ReadLine());
        double result = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value for n = ");
            double nValue = double.Parse(Console.ReadLine());
            result += nValue;           
        }
        Console.WriteLine("Sum of n values = {0}", result);
    }
}

