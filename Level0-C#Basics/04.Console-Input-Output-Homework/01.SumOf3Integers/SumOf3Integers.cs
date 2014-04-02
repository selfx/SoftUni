//  Problem 1. Sum of 3 Integers
//  Write a program that reads 3 integer numbers 
//  from the console and prints their sum.

using System;

class SumOf3Integers
{
    static void Main()
    {
        Console.Write("Enter an integer number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter an integer number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter an integer number c = ");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;
        Console.WriteLine("a + b + c = {0}", sum);
    }
}

