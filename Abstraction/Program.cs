
using Abstraction;
using Abstraction.Topics;
using System.Runtime.Intrinsics;

class Program
{
    private static void Main(string[] args)
    {

        //Inheritance info = new Inheritance("Ade Ife", 23, "Single", "Male", 120000);
        //info.EmployeeInfo(); Another way to print out your info using constructor parameter


        /*LowerEmployee rec = new LowerEmployee();
        rec.fullName = "Ade Ife";
        rec.maritalStatus = "Single";
        rec.age = 30;
        rec.gender = "Male";
        rec.salaryExpectation = 120000;
        rec.defaultSalary = 100000;
        rec.annualSalary();
        rec.EmployeeInfo();


        Console.WriteLine("\n");
        HigherEmployee record = new HigherEmployee();
        record.fullName = "Adelami Rofiat";
        record.maritalStatus = "Married";
        record.age = 30;
        record.gender = "Female";
        record.salaryExpectation = 120000;
        record.salary = 500000;
        record.extraBonuses = 25000;
        record.EmployeeInfo();
        Console.WriteLine("\n");
        record.annualBonus();*/


        // For struct
        Structure D = new Structure(1000237, "Adeflakes Concept", Qualification.BSC, Personnel.EventManagement);
        D.PrintInfo();

        Structure D1 = new Structure();
        D1.Name = "Blessed Showroom";
        D1.Structureid = 1464647;
        D1.Qualification = Qualification.BSC;
        D1.Personnel = Personnel.ProjectManager;
        D1.PrintInfo();

        Structure D2 = new Structure
        {

            Name = "B&G Fashion House",
            Structureid = 3442526,
            Qualification = Qualification.MSC,
            Personnel = Personnel.Designers,

        };
        D2.PrintInfo();


        // for enums
        int[] values = (int[])Enum.GetValues(typeof(Personnel));
        foreach (int value in values)
        {
            Console.WriteLine(value);
        }

        string[] qualification = Enum.GetNames(typeof(Qualification));
        foreach (string value in qualification)
        {
            Console.WriteLine(value);
        }


        // for generics

        var Equal = Calculate<int>.EqualValue(45, 156);
        if (Equal)
        {
            Console.WriteLine("The maximum value is correct");
        }
        else
        {
            Console.WriteLine("The numbers are equal");
        }
        
        var result = Calculate<int>.Add(74, 10, 40);
        if (result >= 100)
        {
            Console.WriteLine("The sales for the week is above 50%");
        }
        else
        {
            Console.WriteLine("The sales for the week is below 50%");
        }
    }
}