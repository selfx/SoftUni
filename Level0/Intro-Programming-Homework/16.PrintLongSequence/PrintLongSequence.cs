//  Problem 16. * Print Long Sequence
//  Write a program that prints the first 1000 members of the sequence: 
//  2, -3, 4, -5, 6, -7, … 
//  You might need to learn how to use loops (search in Internet).

using System;

class PrintLongSequence
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = -1;
        for (int i = 0; i < 499; i++)
        {
            firstNumber = firstNumber + 2;
            secondNumber = secondNumber - 2;
            Console.Write("{0}, {1}, ", firstNumber, secondNumber);
        }
        Console.WriteLine("1000");
    }
}

