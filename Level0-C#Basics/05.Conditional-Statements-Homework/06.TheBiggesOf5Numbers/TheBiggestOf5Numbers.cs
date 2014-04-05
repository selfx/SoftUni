//  Problem 6. The Biggest of Five Numbers
//  Write a program that finds the biggest 
//  of five numbers by using only five if statements.

using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter first number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth number c = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth number c = ");
        double e = double.Parse(Console.ReadLine());

        if ((a > b) && (a > c) && (a > d) && (a > e))
        {
            Console.WriteLine(a);
        }
        else if ((b > a) && (b > c) && (b > d) && (b > e))
        {
            Console.WriteLine(b);
        }
        else if ((c > b) && (c > a) && (c > d) && (c > e))
        {
            Console.WriteLine(c);
        }
        else if ((d > b) && (d > c) && (d > a) && (d > e))
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }       
    }
}
