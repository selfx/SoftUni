//  Problem 7. Sum of 5 Numbers
//  Write a program that enters 5 numbers (given in a single line, 
//  separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers in a single line, separated by a space :");
        string[] stringValues = Console.ReadLine().Split(); //  split the input with space between them
        double firstNumber = double.Parse(stringValues[0]);
        double secondNumber = double.Parse(stringValues[1]);
        double thirdNumber = double.Parse(stringValues[2]);
        double fourthNumber = double.Parse(stringValues[3]);
        double fifthNumber = double.Parse(stringValues[4]);

        double sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;

        Console.WriteLine("The sum of the separeted numbers is : {0}", sum);
    }
}

