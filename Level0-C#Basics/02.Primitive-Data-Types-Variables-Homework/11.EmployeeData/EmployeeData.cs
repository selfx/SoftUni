//  Problem 11. Employee Data   A marketing company wants to keep record of its 
//  employees. Each record would have the following characteristics:
//      First name
//      Last name
//      Age (0...100)
//      Gender (m or f)
//      Personal ID number (e.g. 8306112507)
//      Unique employee number (27560000…27569999)
//  Declare the variables needed to keep the information for a single employee using
//  appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        string employeeFirstName = "Walter";
        string employeeLastName = "Bishop";
        byte employeeAge = 76;
        char employeeGender = 'm';
        ulong employeeIDNumber = 8306112507;
        uint employeeUnoqueNumber = 27569999;

        Console.WriteLine("employee:{0} {1}\nage:{2}\ngender:{3}\nidNumber:{4}\nuniqueNumber:{5}",
            employeeFirstName, employeeLastName, employeeAge, employeeGender, employeeIDNumber, 
            employeeUnoqueNumber);
    }
}

