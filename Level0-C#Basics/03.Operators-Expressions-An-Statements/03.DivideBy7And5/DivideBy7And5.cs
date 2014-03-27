//  Problem 3. Divide by 7 and 5
//  Write a Boolean expression that checks for given integer if it can be divided 
//  (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter integer : ");
        int intValue = int.Parse(Console.ReadLine());
        bool result = ((intValue % 5) == 0) & ((intValue % 7) == 0);
        Console.WriteLine("{0} can be divided by 7 and 5? - {1}",
            intValue, result);
    }
}
