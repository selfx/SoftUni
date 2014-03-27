//  Problem 8. Prime Number Check
//  Write an expression that checks if given positive 
//  integer number n (n ≤ 100) is prime 
//  (i.e. it is divisible without remainder only to itself and 1). 

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter positive integer n <= 100\nn = ");
        int n = int.Parse(Console.ReadLine());

        bool check = ((n == 2) || (n == 3) || (n == 5) || (n == 7)) ||
            ((n != 1) && (n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0) && (n % 7 != 0));
        Console.WriteLine("This integer is prime - {0}", check);
    }
}


