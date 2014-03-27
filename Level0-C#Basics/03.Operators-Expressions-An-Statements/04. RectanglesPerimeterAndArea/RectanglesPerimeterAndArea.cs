//  Problem 4. Rectangles
//  Write an expression that calculates rectangle’s 
//  perimeter and area by given width and height. 

using System;

class RectanglesPerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter rectangle’s width : ");
        double widthValue = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle’s height : ");
        double heightValue = double.Parse(Console.ReadLine());
        double perimeter = (2.0 * widthValue) + (2.0 * heightValue);
        double area = widthValue * heightValue;
        Console.WriteLine("Rectangle’s perimeter is : {0}\nRectangle’s area is : {1}",
            perimeter, area);
    }
}

