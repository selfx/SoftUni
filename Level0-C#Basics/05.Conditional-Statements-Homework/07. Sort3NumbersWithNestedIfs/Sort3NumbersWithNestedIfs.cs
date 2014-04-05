//  Problem 7. Sort 3 Numbers with Nested Ifs
//  Write a program that enters 3 real numbers and prints them 
//  sorted in descending order. Use nested if statements. 
//  Don’t use arrays and the built-in sorting functionality. 

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter first number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number c = ");
        double c = double.Parse(Console.ReadLine());
        string result = null;
        if (a > b && a > c) 
        {
            if (b > c)
            {
                result = a + " " + b + " " + c;
            }
            else
            {
                result = a + " " + c + " " + b;
            }
        }
        else if (a < b && a < c)
        {
            if (b > c)
            {
                result = b + " " + c + " " + a;
            }
            else
            {
                result = c + " " + b + " " + a;
            }
        }
        else
        {
            if (b > a && a > c)
            {
                result = b + " " + a + " " + c;
            }
            else
            {
                result = c + " " + a + " " + b;
            }
        }
        Console.WriteLine("result : " + result);
    }
}

