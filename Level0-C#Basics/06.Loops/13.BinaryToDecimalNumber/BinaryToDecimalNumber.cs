//  Problem 13. Binary to Decimal Number
//  Using loops write a program that converts a binary integer number 
//  to its decimal form. The input is entered as string. The output should
//  be a variable of type long. Do not use the built-in .NET functionality.

using System;

class BinaryToDecimalNumber

{
    static void Main()
    {
        Console.Write("Enter binary integer number : ");
        string s = Console.ReadLine();
        long result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[s.Length - 1- i] != '0')
            {
                result += (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine("In decimal form is : " + result);
    }
}

