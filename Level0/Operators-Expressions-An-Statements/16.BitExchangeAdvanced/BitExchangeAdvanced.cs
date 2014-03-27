//  Problem 16. ** Bit Exchange (Advanced)
//  Write a program that exchanges bits {p, p+1, …, p+k-1} 
//  with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
//  The first and the second sequence of bits may not overlap.

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter 32-bit unsigned integer n = ");
        uint n;
        bool integerCheck = uint.TryParse(Console.ReadLine(), out n); // check if n is 32-bit UInt 
        while (integerCheck == false)
        {
            Console.Write("OUT OF RANGE\nEnter 32-bit unsigned integer n = ");
            integerCheck = uint.TryParse(Console.ReadLine(), out n);
        }

        Console.Write("Enter start bit position of first sequence p = ");
        int p = int.Parse(Console.ReadLine());
        bool pCheck = (p >= 0) && (p < 32); // check if p is in range of 32-bit  
        while (pCheck == false)
        {
            Console.Write("OUT OF RANGE\nEnter start bit position of first sequence p = ");
            integerCheck = uint.TryParse(Console.ReadLine(), out n);
        }
        Console.Write("Enter start bit position of second sequence q = ");
        int q = int.Parse(Console.ReadLine());
        bool qCheck = (q >= 0) && (q < 32); // check if q is in range of 32-bit  
        while (qCheck == false)
        {
            Console.Write("OUT OF RANGE\nEnter start bit position of first sequence p = ");
            integerCheck = uint.TryParse(Console.ReadLine(), out n);
        }
        Console.Write("Enter lenght of the sequences k = ");
        int k = int.Parse(Console.ReadLine());
        bool kCheck = (k + p) < 32 || (k + q) < 32; // check if k is in range of 32-bit  
        while (kCheck == false)
        {
            Console.Write("OUT OF RANGE\nEnter lenght of the sequences k = ");
            integerCheck = uint.TryParse(Console.ReadLine(), out n);
        }


        bool overlapCheck = q > (p + k) || p > (q + k); // check if both sequences overlap
        while (overlapCheck == false)
        {
            Console.Write("OVERLAPPING\nEnter start bit position of first sequence p = ");
            p = int.Parse(Console.ReadLine());
            pCheck = (p >= 0) && (p < 32); // check if p is in range of 32-bit  
            while (pCheck == false)
            {
                Console.Write("OUT OF RANGE\nEnter start bit position of first sequence p = ");
                integerCheck = uint.TryParse(Console.ReadLine(), out n);
            }
            Console.Write("Enter start bit position of second sequence q = ");
            q = int.Parse(Console.ReadLine());
            qCheck = (q >= 0) && (q < 32); // check if q is in range of 32-bit  
            while (qCheck == false)
            {
                Console.Write("OUT OF RANGE\nEnter start bit position of first sequence p = ");
                integerCheck = uint.TryParse(Console.ReadLine(), out n);
            }
            Console.Write("Enter lenght of the sequences k = ");
            k = int.Parse(Console.ReadLine());
            kCheck = (k + p) < 32 || (k + q) < 32; // check if k is in range of 32-bit  
            while (kCheck == false)
            {
                Console.Write("OUT OF RANGE\nEnter lenght of the sequences k = ");
                integerCheck = uint.TryParse(Console.ReadLine(), out n);
            }
            overlapCheck = q > (p + k) || p > (q + k);
        }

        bool outOfRangeCheck = (p + k) <= 32 && (q + k) <= 32; // check if a sequence is out of range
        while (outOfRangeCheck == false)
        {
            Console.Write("OUT OF RANGE\nEnter start bit position of first sequence p = ");
            p = int.Parse(Console.ReadLine());
            pCheck = (p >= 0) && (p < 32); // check if p is in range of 32-bit  
            while (pCheck == false)
            {
                Console.Write("OUT OF RANGE\nEnter start bit position of first sequence p = ");
                integerCheck = uint.TryParse(Console.ReadLine(), out n);
            }
            Console.Write("Enter start bit position of second sequence q = ");
            q = int.Parse(Console.ReadLine());
            qCheck = (q >= 0) && (q < 32); // check if q is in range of 32-bit  
            while (qCheck == false)
            {
                Console.Write("OUT OF RANGE\nEnter start bit position of first sequence p = ");
                integerCheck = uint.TryParse(Console.ReadLine(), out n);
            }
            Console.Write("Enter lenght of the sequences k = ");
            k = int.Parse(Console.ReadLine());
            kCheck = (k + p) < 32 || (k + q) < 32; // check if k is in range of 32-bit  
            while (kCheck == false)
            {
                Console.Write("OUT OF RANGE\nEnter lenght of the sequences k = ");
                integerCheck = uint.TryParse(Console.ReadLine(), out n);
            }
            outOfRangeCheck = (p + k) <= 32 || (q + k) <= 32;
        }

        for (int i = 0; i < k; i++)     // "k" is the number of the loops we need
        {
            uint pBit = (n >> p) & 1;   // exrtact the value of bit {p, p+1,..}
            uint qBit = (n >> q) & 1;   // exrtact the value of bit {q, q+1,..}
            uint maskOne;
            uint maskTwo;

            if (pBit != qBit)
            {
                if (pBit == 0)
                {
                    maskOne = (uint)1 << p;
                    n = n ^ (uint)maskOne;
                    maskTwo = (uint)1 << q;
                    n = n ^ maskTwo;
                }
                else
                {
                    maskOne = (uint)1 << p;
                    n = n ^ maskOne;
                    maskTwo = (uint)1 << q;
                    n = n ^ maskTwo;
                }
            }
            p++;
            q++;

            if (i == (k - 1))   //shows the result, when the loops finished
            {
                Console.WriteLine(n);
            }
        }
    }
}

