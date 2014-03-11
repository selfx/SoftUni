//  Problem 9. Print a Sequence
//  Write a program that prints the first 10 members 
//  of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintNumberSequence
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = -1;
        for (int i = 0; i < 5; i++)
        {
            firstNumber = firstNumber + 2;
            secondNumber = secondNumber - 2;
            Console.Write("{0}, {1}, ", firstNumber, secondNumber);
        }
        Console.WriteLine("...");
    }
}
