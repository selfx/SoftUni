//  Problem 11. * Numbers in Interval Dividable by Given Number
//  Write a program that reads two positive integer numbers and 
//  prints how many numbers p exist between them such that the 
//  reminder of the division by 5 is 0.

using System;

class DividableNumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter first positive integer number a = ");
        uint a = uint.Parse(Console.ReadLine());
        Console.Write("Enter second integer (b > a) number b = ");
        uint b = uint.Parse(Console.ReadLine());
        uint p = 0;

        for (uint i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0}, ", i);
                p++;
            }
        }
        Console.WriteLine("\np = {0}", p);
    }
}

