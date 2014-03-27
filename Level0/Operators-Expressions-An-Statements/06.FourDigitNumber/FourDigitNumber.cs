﻿//  Problem 6. Four-Digit Number
//  Write a program that takes as input a four-digit number in format abcd (e.g. 2011)
//  and performs the following:
//  - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//  - Prints on the console the number in reversed order: dcba (in our example 1102).
//  - Puts the last digit in the first position: dabc (in our example 1201).
//  - Exchanges the second and the third digits: acbd (in our example 2101).
//  The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter Four-Digit Number : ");
        int number = int.Parse(Console.ReadLine());
        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;
        Console.WriteLine("Sum of the digits : {0}+{1}+{2}+{3} = {4}", a, b, c, d, a + b + c + d);
        Console.WriteLine("Numbers digits in reversed order : {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("Last and first digits exchanged : {3}{1}{2}{0}", a, b, c, d);
        Console.WriteLine("Second and third digits exchanged : {0}{2}{1}{3}", a, b, c, d);
    }
}

