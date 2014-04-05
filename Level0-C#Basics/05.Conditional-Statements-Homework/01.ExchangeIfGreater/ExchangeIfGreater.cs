//  Problem 1. Exchange If Greater
//  Write an if-statement that takes two integer variables a and b and 
//  exchanges their values if the first one is greater than the second one. 
//  As a result print the values a and b, separated by a space. 

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter value for a = ");
        double firstInt = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b = ");
        double secondInt = double.Parse(Console.ReadLine());

        if (firstInt > secondInt)
        {
            if ((firstInt % 1 == 0) && (secondInt % 1 == 0)) // check if a and b are integers
            {
                firstInt = firstInt + secondInt;
                secondInt = firstInt - secondInt;
                firstInt = firstInt - secondInt;
            }
        }
        Console.WriteLine(firstInt + " " + secondInt);
    }
}

