//  Problem 12. * Randomize the Numbers 1…N
//  Write a program that enters in integer n and 
//  prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];                // declaging and creating an array
        for (int i = 0; i < n; i++)
        {
            a[i] = i + 1; 
        }
        Random random = new Random();
        for (int i = a.Length - 1; i > 0; i--)
        {
            int r = random.Next(i + 1);
            int temp = a[i];             //  switching each number with another
            a[i] = a[r];                 // from a random position in the deck
            a[r] = temp;
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + ", ");
        }
    }
}

