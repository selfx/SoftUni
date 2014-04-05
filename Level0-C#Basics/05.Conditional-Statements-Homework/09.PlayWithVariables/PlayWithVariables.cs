//  Problem 9. Play with Int, Double and String
//  Write a program that, depending on the user’s choice, inputs an int, double  
//  or string variable. If the variable is int or double, the program increases
//  it by one. If the variable is a string, the program appends "*" at the end. 
//  Print the result at the console. Use switch statement.

using System;

class PlayWithVariables
{
    static void Main()
    {
        Console.WriteLine("Please choose a type : \n1 --> int\n2 --> double\n3 --> string");
        sbyte choice = sbyte.Parse(Console.ReadLine());
        
        switch (choice)
	    {
            case 1:
                {
                    Console.WriteLine("Please enter an integer : ");
                    int intValue = int.Parse(Console.ReadLine());
                    Console.WriteLine(intValue + 1);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Please enter a double : ");
                    double doubleValue = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleValue + 1);
                    break;
                }
            case 3:
                {
                    Console.Write("Please enter a string : ");
                    string stringValue = Console.ReadLine();
                    Console.WriteLine(stringValue + "*");
                    break;
                }
            default:
                {
                    Console.WriteLine("wrong choice");
                    break;
                }
        }
     }
}