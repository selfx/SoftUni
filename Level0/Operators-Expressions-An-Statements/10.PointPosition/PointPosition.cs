//  Problem 10. Point Inside a Circle & Outside of a Rectangle
//  Write an expression that checks for given point (x, y) 
//  if it is within the circle K({1, 1}, 1.5) 
//  and out of the rectangle R(top=1, left=-1, width=6, height=2). 

using System;

class PointPosition
{
    static void Main()
    {
        Console.Write("Enter point's x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter point's y = ");
        double y = double.Parse(Console.ReadLine());

        if ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5) && (y > 1)) == true)
        {
            Console.WriteLine("Inside K & outside of R - Yes");
        }
        else
        {
            Console.WriteLine("Inside K & outside of R - No");
        }
    }
}

