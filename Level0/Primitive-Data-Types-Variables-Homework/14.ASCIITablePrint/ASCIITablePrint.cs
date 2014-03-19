//  Problem 14. * Print the ASCII Table
//  Find online more information about ASCII (American Standard Code for Information Interchange)
//  and write a program to prints the entire ASCII table of characters at the console (characters
//  from 0 to 255). Note that some characters have a special purpose and will not be displayed as
//  expected. You may skip them or display them differently. You may need to use for-loops 
//  (learn in Internet how).

using System;

class ASCIITablePrint
{
    static void Main()
    {
        Console.WriteLine("DEC|HEX|CHAR");

        for (int i = 0; i < 256; i++)
        {
            string iHex = Convert.ToString(i, 16); /* convert integer "i" to string 
                                                  representation in hexadecimal "16" format */

            char iChar = (char)i; // cast character coresponding to integer "i"

            if (i == 7) // character coresponding to 7 is sound
            {
                string iCharString = "beep";
                Console.WriteLine("{0,-3}|{1,-3}|{2}{3}", i, iHex, iChar, iCharString);
            }
            else if (i == 8)
            {
                string iCharString = "backspace";
                Console.WriteLine("{0,-3}|{1,-3}|{2}{3}", i, iHex, iCharString, iChar);
            }

            else if (i == 9)
            {
                string iCharString = "horizontal tab";
                Console.WriteLine("{0,-3}|{1,-3}|{2}{3}", i, iHex, iCharString, iChar);
            }
            else if (i == 10)
            {
                string iCharString = "line feed";
                Console.WriteLine("{0,-3}|{1,-3}|{2}{3}", i, iHex, iCharString, iChar);
            }
            else
            {
                Console.WriteLine("{0,-3}|{1,-3}|{2}", i, iHex, iChar);
            }
        }
    }
}
