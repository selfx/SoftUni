//  Problem 14. Decimal to Binary Number
//  Using loops write a program that converts an integer number 
//  to its binary representation. The input is entered as long. 
//  The output should be a variable of type string. 
//  Do not use the built-in .NET functionality.

	

    using System;
     
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            long input = long.Parse(Console.ReadLine());
     
            long firstBit;
            string binString = string.Empty;
     
            while (input > 0)
            {
                firstBit = input % 2; 
                input /= 2;
                binString = firstBit.ToString() + binString;
            }

            Console.WriteLine("In binary form is : " + binString);
        }
    }

