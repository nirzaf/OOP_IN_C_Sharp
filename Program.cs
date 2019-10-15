using System;

namespace OOP_IN_C_Sharp
{
    public class Employee
    {
        public string FirstName = "First Name ";
        public string LastName = "Last Name ";
        public virtual void FullName()
        {
            Console.WriteLine(FirstName +" "+ LastName);
        }
    }

    public class FullTime : Employee
    {
        public override void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " FullTime Employee");
        }
    }

    public class PartTime : Employee
    {
        public override void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Part Time Employee");
        }
    }

    public class Temp : Employee
    {
        public override void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Temporary Employee");
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
