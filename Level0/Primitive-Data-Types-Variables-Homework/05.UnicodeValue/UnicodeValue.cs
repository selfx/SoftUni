﻿//  Problem 5. Unicode Value
//  Declare a character variable and assign it with the symbol that has Unicode code 72, 
//  and then print it. Hint: first, use the Windows Calculator to find the hexadecimal 
//  representation of 72. The output should be “H”.

using System;

class UnicodeValue
{
    static void Main()
    {
        //  hexadecimal value of 72 is 0x48
        int hexValue = 0x48;
        char unicodeValue = (char)hexValue; //  "(char)" casting to type "char"
        Console.WriteLine(unicodeValue);
    }
}

