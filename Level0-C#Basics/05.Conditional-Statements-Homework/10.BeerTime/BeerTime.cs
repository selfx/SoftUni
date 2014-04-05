﻿//  Problem 10. * Beer Time
//  A beer time is after 1:00 PM and before 3:00 AM. Write a program that 
//  enters a time in format “hh:mm tt” (an hour in range [01...12], a minute 
//  in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time”
//  according to the definition above or “invalid time” if the time cannot be parsed. 
//  Note that you may need to learn how to parse dates and times.

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time (hh:mm tt) - ");
        string inputString = Console.ReadLine();
        try
        {
            DateTime check = Convert.ToDateTime(inputString);
        }
        catch (Exception)
        {
            Console.WriteLine("invalid time");
            return;
        }
        DateTime input = Convert.ToDateTime(inputString);
        DateTime start = Convert.ToDateTime("01:00 PM");
        DateTime stop = Convert.ToDateTime("03:00 AM");
        if ((input >= start) || (input <= stop))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

