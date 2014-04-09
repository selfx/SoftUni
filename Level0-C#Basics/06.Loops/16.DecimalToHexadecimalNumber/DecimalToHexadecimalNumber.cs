//  Problem 16. Decimal to Hexadecimal Number
//  Using loops write a program that converts an integer number 
//  to its hexadecimal representation. The input is entered as long. 
//  The output should be a variable of type string. 
//  Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter integer number : ");
        long input = long.Parse(Console.ReadLine());
        Console.WriteLine("In decimal form is : {0:X}", input);
    }
}

