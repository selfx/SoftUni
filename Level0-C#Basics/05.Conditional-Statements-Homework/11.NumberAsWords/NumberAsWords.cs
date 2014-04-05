//  Problem 11. * Number as Words
//  Write a program that converts a number in the range [0…999] 
//  to words, corresponding to the English pronunciation.

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter number in the range (0…999) : ");
        int input = int.Parse(Console.ReadLine());
        int ones = input % 10;
        int tens = (input / 10) % 10;
        int hundreds = input / 100;
        string stringHundreds = null;
        string stringTens = null;
        string stringOnes = null;
        string and = null;
        
        switch (hundreds)
        {
            case 1:
                stringHundreds = "one hundred";
                break;
            case 2:
                stringHundreds = "two hundred";
                break;
            case 3:
                stringHundreds = "three hundred";
                break;
            case 4:
                stringHundreds = "four hundred";
                break;
            case 5:
                stringHundreds = "five hundred";
                break;
            case 6:
                stringHundreds = "six hundred";
                break;
            case 7:
                stringHundreds = "seven hundred";
                break;
            case 8:
                stringHundreds = "eight hundred";
                break;
            case 9:
                stringHundreds = "nine hundred";
                break;
            default:
                stringHundreds = null;
                break;
        }

        switch (tens)
        {
            case 0:
                stringTens = null;
                break;
            case 2:
                stringTens = "twenty ";
                break;
            case 3:
                stringTens = "thirty ";
                break;
            case 4:
                stringTens = "forty ";
                break;
            case 5:
                stringTens = "fifty ";
                break;
            case 6:
                stringTens = "sixty ";
                break;
            case 7:
                stringTens = "seventy ";
                break;
            case 8:
                stringTens = "eighty ";
                break;
            case 9:
                stringTens = "ninety ";
                break;
            default:
                break;
        }
        if (tens == 1)
        {
            tens = 10 + ones;
            switch (tens)
            {
                case 10:
                    stringTens = "ten";
                    break;
                case 11:
                    stringTens = "eleven";
                    break;
                case 12:
                    stringTens = "twelve";
                    break;
                case 13:
                    stringTens = "thirteen";
                    break;
                case 14:
                    stringTens = "fourteen";
                    break;
                case 15:
                    stringTens = "fifteen";
                    break;
                case 16:
                    stringTens = "sixteen";
                    break;
                case 17:
                    stringTens = "seventeen";
                    break;
                case 18:
                    stringTens = "eighteen";
                    break;
                case 19:
                    stringTens = "nineteen";
                    break;
                default: Console.WriteLine("not a digit");
                    break;
            }
            ones = 0;
        }
        switch (ones)
        {
            case 1:
                stringOnes = "one";
                break;
            case 2:
                stringOnes = "two";
                break;
            case 3:
                stringOnes = "three";
                break;
            case 4:
                stringOnes = "four";
                break;
            case 5:
                stringOnes = "five";
                break;
            case 6:
                stringOnes = "six";
                break;
            case 7:
                stringOnes = "seven";
                break;
            case 8:
                stringOnes = "eight";
                break;
            case 9:
                stringOnes = "nine";
                break;
            default:
                stringOnes = null;
                break;
        }
        if (hundreds == 0 && tens == 0 && ones == 0)
        {
            stringOnes = "zero";
        }
        if (hundreds != 0)
        {
            and = " and ";
        }
        Console.WriteLine("{0}{1}{2}{3}", stringHundreds, and, stringTens, stringOnes);
    }
}

