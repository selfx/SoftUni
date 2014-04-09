//  Problem 9. Matrix of Numbers
//  Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
//  and prints a matrix like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0,2} ", i);
                    for (int j = 1; j < n; j++)
                    {
                        Console.Write("{0,2} ", (i + j));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }
    }
