//  Problem 7. Point in a Circle
//  Write an expression that checks if 
//  given point (x,  y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter x value : ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y value : ");
        double y = double.Parse(Console.ReadLine());
        bool check = (((x * x) + (y * y)) <= 4);
        Console.WriteLine("Point(x, y) is inside a cyrcle K((0, 0), 2)? - {0}", check);
    }
}

