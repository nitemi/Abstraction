using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Inheritance
    {
        public string fullName;
        public int age;
        public string maritalStatus;
        public string gender;
        public int salaryExpectation;

        //public Inheritance(string fullName, int age, string maritalStatus, string gender, int salaryExpectation) 
        //{
        //    this.fullName = fullName;
        //    this.age = age;
        //    this.maritalStatus = maritalStatus;
        //    this.gender = gender;
        //    this.salaryExpectation = salaryExpectation;
            
        
        //}
        public void EmployeeInfo()
        {
            Console.WriteLine("Information about the employee of Adex Nigeria Limited. Please provide the following details:");
            Console.WriteLine("Fullname:"  + fullName);
            Console.WriteLine("Gender:"  +  gender);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Marital Status:"  +  maritalStatus);
            Console.WriteLine("Salary Expectation: "  +  salaryExpectation);
            Console.WriteLine("The information provided above is confidential and will not be shared to a third party.\n signed \n Management.");

        }
    }

    public class LowerEmployee : Inheritance
    {
        public int defaultSalary;
        public void annualSalary()
        {
            Console.WriteLine("Annnual Renumeration is:" + defaultSalary * 12);
        }

    }
    public class HigherEmployee : Inheritance
    {
        public int extraBonuses;
        public int salary;
        public void annualBonus()
        {
            Console.WriteLine("The salary of higher employee's annually is {0}, \nextra bonuses recieved per year is {1}; \nMaking a total of {2}.", salary * 12, extraBonuses * 12, (salary + extraBonuses) * 12);
        }
    }
}