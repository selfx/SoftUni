
//  Problem 14. Modify a Bit at Given Position
//  We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
//  Write a sequence of operators (a few lines of C# code) that modifies n 
//  to hold the value v at the position p from the binary representation of n 
//  while preserving all other bits in n. 

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value (0 or 1) v = ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter position p = ");
        int p = int.Parse(Console.ReadLine());

        int result;
        int mask;
        if (v == 0)
        {
            mask = ~(1 << p);
            result = n & mask;
        }
        else
        {
            mask = 1 << p;
            result = n | mask;
        }
        Console.WriteLine("Result = {0}", result);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
    }
}
