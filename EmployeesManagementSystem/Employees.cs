using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManagementSystem
{
    public class Employees
    {
        private int Id;
        private string Name;
        private double Salary;

        private static readonly List<Employees> EmployeesList = new List<Employees>();

        public static void New()
        {
            Employees employee = new Employees();

            bool validId = false;
            bool validName = false;
            bool validSalary = false;

            Console.WriteLine("Add New Employee\n");
            Console.WriteLine("------------------------------------------------------");

            while (!validId)
            {
                Console.Write("Enter The Id Of The Employee : ");
                string EID = Console.ReadLine();

                if (int.TryParse(EID, out employee.Id) && employee.Id != 0 && !EmployeesList.Any(x => x.Id == employee.Id))
                {
                    validId = true;
                }
                else
                {
                    Console.WriteLine("Please Enter A New Or A Valid ID !!");
                    Console.WriteLine("------------------------------------------------------");
                }
            }

            while (!validName)
            {
                Console.Write("Enter The Name Of The Employee : ");
                employee.Name = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(employee.Name) && !ValidateName(employee.Name))
                {
                    validName = true;
                }
                else
                {
                    Console.WriteLine("Please Enter A Valid Name !!");
                    Console.WriteLine("------------------------------------------------------");
                }
            }

            while (!validSalary)
            {
                Console.Write("Enter The Salary Of The Employee : ");
                string ESalary = Console.ReadLine();

                if (double.TryParse(ESalary, out employee.Salary) && employee.Salary != 0)
                {
                    validSalary = true;
                }
                else
                {
                    Console.WriteLine("please Enter A Valid Salary !!");
                    Console.WriteLine("------------------------------------------------------");
                }
            }

            EmployeesList.Add(employee);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Employees Added Successfully . . . ");
        }

        public static void Display()
        {
            Console.WriteLine("The List Of Employees\n");
            Console.WriteLine("------------------------------------------------------");

            if (EmployeesList.Count != 0)
            {
                foreach (var employee in EmployeesList)
                {
                    Console.WriteLine("Employee ID is : " + employee.Id);
                    Console.WriteLine("Employee Name is : " + UpperCaseFirst(employee.Name));
                    Console.WriteLine("Employee Salary is : $" + employee.Salary);
                    Console.WriteLine("------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("List Of Employees is Empty . . . ");
                Console.WriteLine("------------------------------------------------------");
            }
        }

        public static void Sort()
        {
            List<Employees> sortedEmployees = EmployeesList.OrderBy(x => x.Name).ToList();

            Console.WriteLine("The List Of Sorted Employees\n");
            Console.WriteLine("------------------------------------------------------");

            if (sortedEmployees.Count != 0)
            {
                int i = 0;

                foreach (var emp in sortedEmployees)
                {
                    Console.Write("{0}. ", (i + 1));
                    Console.WriteLine(UpperCaseFirst(emp.Name));
                    i++;
                }
                Console.WriteLine("------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("List Of Sorted Employees is Empty . . . ");
                Console.WriteLine("------------------------------------------------------");
            }
        }

        private static string UpperCaseFirst(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1);
        }

        private static bool ValidateName(string name)
        {
            return name.Any(char.IsDigit);
        }
    }
}
