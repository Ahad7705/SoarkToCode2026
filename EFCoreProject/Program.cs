using EFCoreProject.Models;
using System;

namespace EFCoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProjectContext context = new ProjectContext();

            using (var context = new ProjectContext())
            {

                //add data on table employees

                //Employee e1 = new Employee();

                //e1.EmployeeFname = "Ahad";
                //e1.EmployeeSalary = 600;
                

                //context.employees.Add(e1);
                //context.SaveChanges();


                //Case 1: register employee

                //Console.WriteLine("Register employee");

                //Employee e1 = new Employee();

                //Console.WriteLine("Enter First Name");
                //e1.EmployeeFname = Console.ReadLine();

                //Console.WriteLine("Enter Last Name");
                //e1.EmployeeLname = Console.ReadLine();

                //Console.WriteLine("Enter Salary");
                //e1.EmployeeSalary = double.Parse(Console.ReadLine());

                //context.employees.Add(e1);
                //context.SaveChanges();


                //Case 2: delete employee

                Console.WriteLine("Enter employee ID to delete");

                int id = int.Parse(Console.ReadLine());

                Employee employee =
                    context.employees.FirstOrDefault(e => e.EmployeeId == id);

                if (employee == null)
                {
                    Console.WriteLine("Employee not found");
                }
                else
                {
                    context.employees.Remove(employee);
                    context.SaveChanges();

                    Console.WriteLine("Employee deleted successfully");
                }

            } 
        }
    }
}//end context


