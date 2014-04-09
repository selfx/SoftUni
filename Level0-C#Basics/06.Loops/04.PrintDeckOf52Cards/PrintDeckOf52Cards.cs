//  Problem 4. Print a Deck of 52 Cards
//  Write a program that generates and prints all possible cards from a standard
//  deck of 52 cards (without the jokers). The cards should be printed using
//  the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should
//  start from 2 to A. Print each card face in its four possible suits: clubs, 
//  diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        char clubs = '♣';
        char diamonds = '♦';
        char hearts = '♥';
        char spades = '♠';

        for (int i = 2; i < 15; i++)    // loop to roll all lines (as 11="J", 12="D", 13="K", 14= "A")
        {            
            for (int q = 0; q < 4; q++)     // loop to add type to each line
            {
                string value = i.ToString().PadLeft(2, ' ');    // convert the line number to string
                switch (i)                                                                                                          
                {
                    case 11: value = " J"; break;               // declaring different values 
                    case 12: value = " D"; break;
                    case 13: value = " K"; break;
                    case 14: value = " A"; break;
                    default:
                        break;
                }
                Console.Write(value);           // print line value
                switch (q)
                {
                    case 0: Console.Write((char)clubs + " "); ; break;    // print each type + space
                    case 1: Console.Write((char)diamonds + " "); break;   // and add new line with the last
                    case 2: Console.Write((char)hearts + " "); break;
                    case 3: Console.Write((char)spades + " \n"); break;
                    default: break;
                }
            }            
        }                
    }
}

