//  Problem 13. Null Values Arithmetic
//  Create a program that assigns null values to an integer 
//  and to a double variable. Try to print these variables at the console. 
//  Try to add some number or the null literal to these variables and print the result.

using System;

class Program
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("a={0}\nb={1}", a, b);
        a += 5;
        b += 3;
        Console.WriteLine("a+5={0}\nb+3={1}", a, b);

    }
}
