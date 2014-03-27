//  Problem 12. Extract Bit from Integer
//  Write an expression that extracts from given 
//  integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter integer n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter index p = ");
        int p = int.Parse(Console.ReadLine());

        int mask = n >> p;
        int result = mask & 1;
        Console.WriteLine("Bit @ p is {0}", result);
    }
}
