//  Problem 10. Exchange Variable Values
//  Declare two integer variables a and b and assign 
//  them with 5 and 10 and after that exchange their values. 
//  Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a={0}\nb={1}", a, b);
        b = a + b;
        a = b - a;
        b = b - a;
        Console.WriteLine("exchange their values\na={0}\nb={1}", a, b);
    }
}

