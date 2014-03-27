//  Problem 13. Check a Bit at Given Position
//  Write a Boolean expression that returns if the bit 
//  at position p (counting from 0, starting from the right) 
//  in given integer number n has value of 1. 

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position p = ");
        int p = int.Parse(Console.ReadLine());

        int mask = n >> p;
        Console.WriteLine(mask);
        bool result = (mask & 1) == 1;
        Console.WriteLine("bit @ p == 1 - {0}", result);
    }
}
