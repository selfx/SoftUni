//  Problem 4. Multiplication Sign
//  Write a program that shows the sign (+, - or 0) of the product of three 
//  real numbers, without calculating it. Use a sequence of if operators.

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter first real number a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number c = ");
        double c = double.Parse(Console.ReadLine());
        string result = null;
        if (a == 0 || b == 0 || c == 0)
        {
            result = "0";
        }
        else if ((a < 0) && (b < 0))
        {
            if (c < 0)
            {
                result = "-";
            }
            else
            {
                result = "+";
            }
        }       
        else if ((a < 0) || (b < 0))
        {
            if (c < 0)
            {
                result = "+";
            }
            else
            {
                result = "-";
            }
        }
        else if (c < 0)
        {
            result = "-";
        }
        else
        {
            result = "+";
        }
        Console.WriteLine(result);
    }
}

