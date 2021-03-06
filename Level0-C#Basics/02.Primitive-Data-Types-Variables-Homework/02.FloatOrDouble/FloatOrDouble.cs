﻿//  Problem 2. Float or Double?
//  Which of the following values can be assigned to a variable of type float 
//  and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//  Write a program to assign the numbers in variables and print them to ensure 
//  no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstValue = 34.567839023;
        float secondValue = 12.345f;
        double thirdValue = 8923.1234857;
        float fourthValue = 3456.091f;
        Console.WriteLine("{0,-14} double\n{1,-14} float\n{2,-14} double\n{3,-14} float",
            firstValue, secondValue, thirdValue, fourthValue);
    }
}

