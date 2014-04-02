//  Problem 4. Number Comparer
//  Write a program that gets two numbers from the console and prints
//  the greater of them. Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter an integer number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter an integer number b = ");
        double b = double.Parse(Console.ReadLine());
        double bigger = Math.Max(a, b);
        Console.WriteLine("greater is {0}", bigger);
    }
}