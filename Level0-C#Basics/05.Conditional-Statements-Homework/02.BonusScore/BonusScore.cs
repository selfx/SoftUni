//  Problem 2. Bonus Score
//  Write a program that applies bonus score to given score 
//  in the range [1…9] by the following rules:
//  - If the score is between 1 and 3, the program multiplies it by 10.
//  - If the score is between 4 and 6, the program multiplies it by 100.
//  - If the score is between 7 and 9, the program multiplies it by 1000.
//  - If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score value (from 1 to 9): ");
        byte scoreValue = byte.Parse(Console.ReadLine());
        object result;
        if (scoreValue >= 1 && scoreValue <= 3)
        {
            result = scoreValue * 10;
        }
        else if (scoreValue >= 4 && scoreValue <= 6)
        {
            result = scoreValue * 100;
        }
        else if (scoreValue >= 7 && scoreValue <= 9)
        {
            result = scoreValue * 1000;
        }
        else
        {
            result = "invalid score";
        }
        Console.WriteLine(result);
    }
}

