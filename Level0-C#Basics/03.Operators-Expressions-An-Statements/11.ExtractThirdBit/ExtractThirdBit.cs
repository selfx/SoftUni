//Problem 11. Bitwise: Extract Bit #3
//  Using bitwise operators, write an expression 
//  for finding the value of the bit #3 of a given unsigned integer. 
//  The bits are counted from right to left, starting from bit #0. 
//  The result of the expression should be either 1 or 0. 

using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Enter unsigned integer x = ");
        int x = int.Parse(Console.ReadLine());
        int mask = x >> 3;
        int result = mask & 1;
        Console.WriteLine("Bit #3 is {0}", result);
    }
}
