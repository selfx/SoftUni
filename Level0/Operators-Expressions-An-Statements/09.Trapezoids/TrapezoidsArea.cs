//  Problem 9. Trapezoids
//  Write an expression that calculates trapezoid's 
//  area by given sides a and b and height h.

using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.Write("Enter trapezoid's base a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid's base b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid's height h = ");
        double h = double.Parse(Console.ReadLine());

        double area = h / 2 * (a + b);
        Console.WriteLine("Trapezoid's area = {0}",area);
    }
}
