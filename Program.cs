using System;

namespace OOP_IN_C_Sharp
{
    public class Employee
    {
        public string FirstName = "First Name ";
        public string LastName = "Last Name ";
        public void FullName()
        {
            Console.WriteLine(FirstName +" "+ LastName);
        }
    }

    public class FullTime : Employee
    {
        public void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTime : Employee
    {
        public void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class Temp : Employee
    {
        public void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTime();
            employees[2] = new FullTime();
            employees[3] = new Temp();
            foreach (var emp in employees)
            {
                emp.FullName();
            }
        }
    }
}
