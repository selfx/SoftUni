//  Problem 12. * Zero Subset
//  We are given 5 integer numbers. Write a program that finds 
//  all subsets of these numbers whose sum is 0. Assume that
//  repeating the same subset several times is not a problem.

using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Enter first integer : ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer : ");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer : ");
        int thirdInt = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth integer : ");
        int fourthInt = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth integer : ");
        int fifthInt = int.Parse(Console.ReadLine());

        if (firstInt == 0 && secondInt == 0 && thirdInt == 0 && fourthInt == 0 && fifthInt == 0)
        {
            Console.WriteLine(firstInt + " + " + secondInt + " + " + thirdInt + " + " + fourthInt +
                     " + " + fifthInt + " = " + (firstInt + secondInt + thirdInt + fourthInt + fifthInt));
            return;
        }

        bool noSubsetCheck = true;
        if (firstInt + secondInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstInt, secondInt);
            noSubsetCheck = false;
        }
        if (firstInt + thirdInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstInt, thirdInt);
            noSubsetCheck = false;
        }
        if (firstInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstInt, fourthInt);
            noSubsetCheck = false;
        }
        if (firstInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstInt, fifthInt);
            noSubsetCheck = false;
        }
        if (secondInt + thirdInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondInt, thirdInt);
            noSubsetCheck = false;
        }
        if (secondInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondInt, fourthInt);
            noSubsetCheck = false;
        }
        if (secondInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondInt, fifthInt);
            noSubsetCheck = false;
        }
        if (thirdInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdInt, fourthInt);
            noSubsetCheck = false;
        }
        if (thirdInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdInt, fifthInt);
            noSubsetCheck = false;
        }
        if (fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (firstInt + secondInt + thirdInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstInt, secondInt, thirdInt);
            noSubsetCheck = false;
        }
        if (firstInt + secondInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstInt, secondInt, fourthInt);
            noSubsetCheck = false;
        }
        if (firstInt + secondInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstInt, secondInt, fifthInt);
            noSubsetCheck = false;
        }
        if (firstInt + thirdInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstInt, thirdInt, fourthInt);
            noSubsetCheck = false;
        }
        if (firstInt + thirdInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstInt, thirdInt, fifthInt);
            noSubsetCheck = false;
        }
        if (firstInt + fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstInt, fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (secondInt + thirdInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondInt, thirdInt);
            noSubsetCheck = false;
        }
        if (secondInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondInt, fourthInt);
            noSubsetCheck = false;
        }
        if (secondInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondInt, fifthInt);
            noSubsetCheck = false;
        }
        if (secondInt + thirdInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondInt, thirdInt, fourthInt);
            noSubsetCheck = false;
        }
        if (secondInt + thirdInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondInt, thirdInt, fifthInt);
            noSubsetCheck = false;
        }
        if (secondInt + fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondInt, fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (thirdInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdInt, fourthInt);
            noSubsetCheck = false;
        }
        if (thirdInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdInt, fifthInt);
            noSubsetCheck = false;
        }
        if (thirdInt + fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdInt, fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} = 0", fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (firstInt + secondInt + thirdInt + fourthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstInt, secondInt, thirdInt, fourthInt);
            noSubsetCheck = false;
        }
        if (firstInt + secondInt + thirdInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstInt, secondInt, thirdInt, fifthInt);
            noSubsetCheck = false;
        }
        if (firstInt + secondInt + fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstInt, secondInt, fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (firstInt + thirdInt + fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstInt, thirdInt, fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (secondInt + thirdInt + fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", secondInt, thirdInt, fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (firstInt + secondInt + thirdInt + fourthInt + fifthInt == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", firstInt, secondInt, thirdInt, fourthInt, fifthInt);
            noSubsetCheck = false;
        }
        if (noSubsetCheck == true)
        {
            Console.WriteLine("no zero subset");
        }
    }
}


