//  Problem 3. Min, Max, Sum and Average of N Numbers
//  Write a program that reads from the console a sequence of n integer 
//  numbers and returns the minimal, the maximal number, the sum and the 
//  average of all numbers (displayed with 2 digits after the decimal point). 
//  The input starts by the number n (alone in a line) followed by n lines, 
//  each holding an integer number.

using System;

class MinMaxSumAverageOfNumbers
{
    static void Main()
    {
        Console.Write("Enter number of integers n = ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayN = new int[n];
        int min = 0;
        int max = 0;
        int sum = 0;
        float avg = 0;
        // declaring array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter integer = ");
            arrayN[i] = int.Parse(Console.ReadLine());
        }
        // get min
        min = arrayN[0];
        for (int i = 1; i < n; i++)
        {
            if (arrayN[i] < arrayN[0])
            {
                min = arrayN[i];
            }
        }
        Console.WriteLine("min = {0}", min);
        // get max
        max = arrayN[0];
        for (int i = 1; i < n; i++)
        {            
            if (arrayN[i] > max)
            {
                max = arrayN[i];
            }
        }
        Console.WriteLine("max = {0}", max);
        // get sum
        for (int j = 0; j < n; j++)
        {
            sum += arrayN[j];          
        }
        Console.WriteLine("sum = {0}", sum);
        // get avg
        avg = (float)sum / n;
        Console.WriteLine("avg = {0:F2}", avg);
    }
}

