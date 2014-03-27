//  Problem 1. Declare Variables
//  Declare five variables choosing for each of them the most appropriate 
//  of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
//  the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough 
//  type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariable
{
    static void Main()
    {
        ushort firstValue = 52130;
        sbyte secondValue = -115;
        int thirdValue = 4825932;
        byte fourthValue = 97;
        short fifthValue = -10000;
        Console.WriteLine("{0,-8} ushort\n{1,-8} sbyte\n{2,-8} int\n{3,-8} byte\n{4,-8} short",
            firstValue, secondValue, thirdValue, fourthValue, fifthValue);
        // {0,-8} => place the variable "0" in "8" positioned string, starting from right "-"
    }
}

