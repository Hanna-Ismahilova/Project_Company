using System;
using System.Collections.Generic;

//temat1/zadanie6
namespace Finances.Employees
{
   public class Employee : Person
    {
        
        public int EmployeeId { get; set; }  
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public int AccountNumber { get; set; }

        //temat1/zadanie2
        public static int HolidayBonus = 1000;
        //temat1/zadanie3
        private Wage _wage;
        //temat1/zadanie2
        public List<Operation> _listOfOperations = new List<Operation>();
        //temat1/zadanie4
        private Contract _contract { get; set; }


        //temat1/zadanie3
        public struct Wage 
        {
            public int Basic { get; set; }
            public int Bonus { get; set; }
            public int Other { get; set; }
        }

        //temat1/zadanie4
        public enum Contract 
        {
            Fulltime,
            PartTime,
            Contract
        }

        //temat1/zadanie9
        public Employee()
        {

        }

        //temat1/zadanie9
        public Employee(int id, string firstName, string lastName, int age, int employeeId, string jobTitle, int salary) : base(id, firstName, lastName, age) 
        {
            EmployeeId = employeeId;
            JobTitle = jobTitle;
            Salary = salary;
        }

        //temat1/zadanie9
        public Employee(int id, string firstName, string lastName, int age) : base(id, firstName, lastName, age)
        {
            _listOfOperations = new List<Operation>();
            _wage = new Wage();
        }

        //temat1/zadanie5
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Id: {EmployeeId}\nJob title: {JobTitle}\nSalary: {Salary}\n");
        }

        //temat1/zadanie5
        public void ChangeEmployeeInfo(string jobTitle, int salary)
        {
           JobTitle = jobTitle;
            Salary = salary;
        }

        //temat1/zadanie5
        public void ChangeHolidayBonus(int holidayBonus)
        {
            HolidayBonus = holidayBonus;
        }

        //temat1/zadanie5
        public Wage GetWage()
        {
            //temat2/zadanie1
            Console.Write("Enter username: ");
            var givenLogin = Console.ReadLine();
            Console.Write("Enter password: ");
            var givenPass = Console.ReadLine();
            if (givenLogin == "u3ername" && givenPass == "passw0rd")
            {
                return _wage;
            }
            Console.WriteLine("Wrong credentials");
            return new Wage();
        }

        //temat1/zadanie5
        public void SetWage(int basicWage, int bonusWage, int otherWage)
        {
            //temat2/zadanie1
            Console.Write("Enter username: ");
            var givenLogin = Console.ReadLine();
            Console.Write("Enter password: ");
            var givenPass = Console.ReadLine();
            if (givenLogin == "u3ername" && givenPass == "passw0rd")
            {
                _wage.Basic = basicWage;
                _wage.Bonus = bonusWage;
                _wage.Other = otherWage;
            }
            else
            {
                Console.WriteLine("Wrong credentials");
            }
        }

        //temat1/zadanie5
        public void Payroll(int id, string nameOfPayroll)
        {
            _listOfOperations.Add(new Operation(id, DateTime.Now, nameOfPayroll));
            Console.WriteLine(nameOfPayroll);
        }

    }
}
