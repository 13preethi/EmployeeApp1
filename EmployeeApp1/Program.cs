using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary1;
using System.IO;

namespace EmployeeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails employee1 = new EmployeeDetails();
            Employee emp = new Employee();
          
            string ans;
            do
            {

                Console.WriteLine("Enter  1.Add Employee 2.Remove Employee by Id 3.Update Employee 4. Get Employee by ID 5. Get Employee By Name 6. Get All Employees");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1: 
                        employee1.Add(emp);
                        break;

                    case 2:
                        employee1.RemoveEmployee(emp);
                     break;

                    case 3:
                        employee1.UpdateEmployee();
                       break;

                    case 4:
                        employee1.GetEmployeeById();
                       break;
                    case 5:
                        employee1.GetEmployeeByName();
                       break;

                    case 6:
                        employee1.GetAllEmployees();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue?yes/no?");
                ans = Console.ReadLine();
            } while (ans == "yes");
            Console.ReadLine();
        }

    }
    }


