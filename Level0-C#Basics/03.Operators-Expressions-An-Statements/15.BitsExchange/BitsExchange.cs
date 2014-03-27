//  Problem 15. * Bits Exchange
//  Write a program that exchanges bits 3, 4 and 5 with  
//  bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter unsigned integer(from 0 to 4294967295)\nn = ");
        uint n = uint.Parse(Console.ReadLine());

        uint bit24 = (n >> 24) & 1;     // extract the bit value from position 24
        uint bit25 = (n >> 25) & 1;
        uint bit26 = (n >> 26) & 1;
        uint bit3 = (n >> 3) & 1;
        uint bit4 = (n >> 4) & 1;
        uint bit5 = (n >> 5) & 1;

        uint maskOne;
        uint maskTwo;

        if (bit24 != bit3)
        {
            if (bit24 == 0)
            {
                maskOne = 1 << 3;
                n = n & ~maskOne;         //set bit3 value to 1
                maskTwo = 1 << 24;        //set bit24 value to 0
                n = n | maskTwo;                
            }
            else
            {
                maskOne = 1 << 3;
                n = n | maskOne;          //set bit3 value to 0
                maskTwo = 1 << 24;        //set bit24 value to 1
                n = n & ~maskTwo;               
            }
        }

        if (bit25 != bit4)
        {
            if (bit25 == 0)
            {
                maskOne = 1 << 4;
                n = n & ~maskOne;
                maskTwo = 1 << 25;
                n = n | maskTwo;
            }
            else
            {
                maskOne = 1 << 4;
                n = n | maskOne;
                maskTwo = 1 << 25;
                n = n & ~maskTwo;
            }
        }

        if (bit26 != bit5)
        {
            if (bit26 == 0)
            {
                maskOne = 1 << 5;
                n = n & ~maskOne;
                maskTwo = 1 << 26;
                n = n | maskTwo;
                Console.WriteLine(n);
            }
            else
            {
                maskOne = 1 << 5;
                n = n | maskOne;
                maskTwo = 1 << 26;
                n = n & ~maskTwo;
                Console.WriteLine(n);
            }
        }
        else
        {
            Console.WriteLine(n);
        }
    }
}

