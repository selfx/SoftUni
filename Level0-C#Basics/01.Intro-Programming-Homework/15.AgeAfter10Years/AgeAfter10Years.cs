﻿//  Problem 15. * Age after 10 Years
//  Write a program to read your age from the console  
//  and print how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your age : ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you'll be {0} years old.", age + 10);
    }
}

