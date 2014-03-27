//  Problem 2. Gravitation on the Moon
//  The gravitational field of the Moon is approximately 17% of that on the Earth. 
//  Write a program that calculates the weight of a man on the moon by a given weight 
//  on the Earth.

using System;

    class MoonGravitationCalculator
    {
        static void Main()
        {
            Console.Write("Enter weight on the Earth : ");
            double earthWeight = double.Parse(Console.ReadLine());
            double moonWeight = (earthWeight / 100.0) * 17.0;
            Console.WriteLine("The same weight on the Moon will be : {0}", moonWeight);
        }
    }

