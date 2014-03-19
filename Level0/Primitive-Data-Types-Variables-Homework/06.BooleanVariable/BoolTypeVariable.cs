//  Problem 6. Boolean Variable
//  Declare a Boolean variable called isFemale and assign an appropriate value 
//  corresponding to your gender. Print it on the console.

using System;

class BoolTypeVariable
{
    static void Main()
    {
        Console.WriteLine("Type your gender \"male\" or \"female\", then press enter");
        string gender = Console.ReadLine();
        Console.Clear();                        // "Console.Clear()" clear the console
        bool isFemale = gender == "female";
        Console.WriteLine("You are female - {0}", isFemale);
    }
}

