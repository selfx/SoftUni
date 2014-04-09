//  Problem 17. * Calculate GCD
//  Write a program that calculates the greatest common divisor (GCD) 
//  of given two integers a and b. Use the Euclidean algorithm.

using System;

class CalculatingGCD
{
    static void Main()
    {
        Console.Write("Enter first number a =  ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number b = ");
        int b = int.Parse(Console.ReadLine());
        int reminder = new int();  // declaring reminder

        if (a == 0 || b == 0)
        {
            Console.WriteLine(a);
            return;
        }
        if (a < b)
        {                // exchange a and b
            b = a + b;
            a = b - a;
            b = b - a;
        }
        do
        {
            reminder = a % b;      // get the reminder
            a = b;
            b = reminder;
        } while (reminder != 0);

        Console.WriteLine(a);
    }
}

