//  Problem 2. Print Company Information
//  A company has name, address, phone number, fax number,
//  web site and manager. The manager has first name, last name, age
//  and a phone number. Write a program that reads the information
//  about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter Company's name : ");
        string companyName = Console.ReadLine();
        Console.Write("Enter Company's address : ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter Company's phone number : ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter Company's fax number or \"no\" : ");
        string companyFax = Console.ReadLine();
        if (companyFax == "no")
        {
            companyFax = "(no fax)";
        }
        Console.Write("Enter Company's web site : ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Enter manager's first name : ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager's last name : ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager's age : ");
        string managerAge = Console.ReadLine();
        Console.Write("Enter manager's phone number : ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\n{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}", 
            companyName, companyAddress, companyPhone, companyFax, companyWebSite);
        Console.WriteLine("Manager: {0} {1} (are: {2}, phone: {3})", 
            managerFirstName, managerLastName, managerAge, managerPhone);
    }
}