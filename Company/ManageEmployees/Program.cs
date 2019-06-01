using Finances.Employees;
using System;

namespace ManageEmployees
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //temat8/zadanie1,2
            var employee2 = EmployeeFactory.CreateEmployee(2, "RandomName2", "RandomLastName2", 18);
            Console.WriteLine($"Before changes: {employee2.FirstName} {employee2.LastName}");
            Action<string, string> changeSomething = employee2.ChangeEmployeeName;
            changeSomething("DelegateName2", "DelegateLastName2");
            Console.WriteLine($"After changes:  {employee2.FirstName} {employee2.LastName}");
            Console.ReadKey();
            */

            //temat8/zadanie1,2
            var employee = EmployeeFactory.CreateEmployee(1, "RandomName", "RandomLastName", 18);
            Console.WriteLine($"Before changes: {employee.FirstName} {employee.LastName}");
            employee.AddCallback(CallbackInfo);
            employee.ChangeEmployeeName("DelegateName", "DelegateLastName");
            Console.WriteLine($"After changes:  {employee.FirstName} {employee.LastName}");
            Console.ReadKey();
        }
        //temat8/zadanie1,2
        static void CallbackInfo(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Callback has been used.");
        }

    }
    }
}
