//  Problem 6. Quadratic Equation
//  Write a program that reads the coefficients a, b and c 
//  of a quadratic equation ax^2 + bx + c = 0 
//  and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter (a /= 0) a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c = ");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - 4 * a * c; // get discriminant       
        
        double rootOne = (-b - Math.Sqrt(d)) / (2 * a);
        double rootTwo = (-b + Math.Sqrt(d)) / (2 * a);

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            Console.WriteLine("x(1) = x(2) = {0}", rootOne);
        }
        else
        {
            Console.WriteLine("x(1) = {0}; x(2) = {1}", rootOne, rootTwo);
        }        
    }
}

