//  Problem 5. Formatting Numbers
//  Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
//  a floating-point b and a floating-point c and prints them in 4 virtual 
//  columns on the console. Each column should have a width of 10 characters.
//  The number a should be printed in hexadecimal, left aligned; then the number 
//  a should be printed in binary form, padded with zeroes, then the number b 
//  should be printed with 2 digits after the decimal point, right aligned; 
//  the number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer number (0 <= a <= 500) a = ");
        ushort a = ushort.Parse(Console.ReadLine());
        Console.Write("Enter an integer number b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter an integer number c = ");
        float c = float.Parse(Console.ReadLine());
        
        string aBinary = Convert.ToString(a, 2).PadLeft(10, '0');
        string bString = (b == (int)b) ? b.ToString() : String.Format("{0:0.00}", b);
        string cString = (c == (int)c) ? c.ToString() : String.Format("{0:0.000}", c);
                
        Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10}|{3, -10}|", 
            a, aBinary, bString, cString);
    }
}