//  Problem 3. Circle Perimeter and Area
//  Write a program that reads the radius r of a circle and prints
//  its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle radius r = ");
        double a = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * a;
        double area = Math.PI * (a * a);
        Console.WriteLine("Circle's perimeter = {0:F2}\nCircle's area = {1:F2}", 
            perimeter, area);
    }
}