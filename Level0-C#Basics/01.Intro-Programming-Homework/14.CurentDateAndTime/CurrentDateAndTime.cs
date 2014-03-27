//  Problem 14. * Current Date and Time
//  Create a console application that prints the current date and time. 
//  Find in Internet how.

using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime date1 = DateTime.Now;
        DateTime date2 = DateTime.UtcNow;

        Console.WriteLine("Local - {0}\nUtc   - {1}", date1, date2);
    }
}