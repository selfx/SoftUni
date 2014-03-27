//  Problem 5. Third Digit is 7?
//  Write an expression that checks for given integer 
//  if its third digit from right-to-left is 7.

using System;

class IsThirdDigit7
{
    static void Main()
    {
        Console.Write("Enter integer value : ");
        int intValue = int.Parse(Console.ReadLine());
        bool check = ((intValue / 100) % 10) == 7;
        Console.WriteLine("Third digit is 7? - {0}", check);
    }
}
