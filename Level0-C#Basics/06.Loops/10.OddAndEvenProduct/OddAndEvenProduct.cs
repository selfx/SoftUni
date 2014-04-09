//  Problem 10. Odd and Even Product
//  You are given n integers (given in a single line, separated by a space). 
//  Write a program that checks whether the product of the odd elements 
//  is equal to the product of the even elements. Elements are counted 
//  from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int evenProduct = 1;
        int oddProduct = 1;
        for (int i = 0; i < input.Length; i++)
        {
            int arrayValue = int.Parse(input[i]);
            if (i % 2 == 0)
            {
                oddProduct *= arrayValue;
            }
            else
            {
                evenProduct *= arrayValue;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes\nproduct = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
        }
    }
}

