//  Problem 15. Hexadecimal to Decimal Number
//  Using loops write a program that converts a hexadecimal integer number 
//  to its decimal form. The input is entered as string. The output should 
//  be a variable of type long. Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter hexadecimal integer number : ");
        string input = Console.ReadLine();
        long x;
        bool check = long.TryParse(input, out x);
        Int64 number = Convert.ToInt64(input, 16);
        Console.WriteLine("In decimal form is : " + number);
    }
}

