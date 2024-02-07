using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace EmployeeLibrary1
{
   public class EmployeeDetails : IEmployee
    {
        string fileName = ConfigurationManager.AppSettings["FileName"];
       
        public void Add(Employee employee)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
                Console.Write("Enter Employee ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Employee Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Salary: ");
                double sal= Convert.ToDouble(Console.ReadLine());
               
                Console.WriteLine("Employee is added successfully");
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
               {
                  using (StreamWriter sw = new StreamWriter(fs))
                 {
                    sw.WriteLine($"{id},{name},{age},{sal}");
                 }
               }
        }
        public  void RemoveEmployee(Employee employee)
        {
            Console.Write("Enter Employee Id to be removed: ");
            int id = Convert.ToInt32(Console.ReadLine());
            string[] s = File.ReadAllLines(fileName);
            using(StreamWriter sw=new StreamWriter(fileName))
            {
                foreach(string s1 in s)
                {
                    int id1 = Convert.ToInt32(s1.Split(',')[0]);
                    if (id1 != id)
                    {
                        sw.WriteLine(s1);
                    }
                }
                Console.WriteLine("employee removed");
            }
        }
        public void UpdateEmployee()
        {
            Console.Write("Enter Employee Id to be updated: ");
            int uid = Convert.ToInt32(Console.ReadLine());
            string[] s = File.ReadAllLines(fileName);
          
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (string s1 in s)
                    {

                        int id = Convert.ToInt32(s1.Split(',')[0]);
                        if (uid == id)
                        {
                            Console.WriteLine("Enter details:");
                            Console.WriteLine("name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Age:");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Salary:");
                            double sal = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Employee updated successfully");
                            sw.WriteLine($"{id},{name},{age},{sal}");
                     
                        }
                        else
                        {
                            sw.WriteLine(s1);
                        }

                    }
                }
            
        }
        public void GetAllEmployees()
        {
            foreach (string s in File.ReadAllLines(fileName))
            {
                string[] s1 = s.Split(',');
                Console.WriteLine($"Employee ID:{s1[0]}, Employee Name:{s1[1]}, Employee Age:{s1[2]}, Employee Salary:{s1[3]}");
            }
        }
        public Employee GetEmployeeByName()
        {
            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();
            foreach (string s in File.ReadAllLines(fileName))
            {
                string[] s1 = s.Split(',');
                if (s1[1].Equals(empName))
                {
                    Console.WriteLine($"Employee ID:{s1[0]}, Employee Name:{s1[1]}, Employee Age:{s1[2]}, Employee Salary:{s1[3]}");

                }
            }


            return null;
        }
        public Employee GetEmployeeById()
        {
            Console.Write("Enter Employee Id: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            string file = File.ReadAllLines(fileName).FirstOrDefault(file1=>Convert.ToInt32(file1.Split(',')[0])==empId);
 
            if (file != null)
            {
                string[] s1 = file.Split(',');
                Console.WriteLine($"Employee ID:{s1[0]}, Employee Name:{s1[1]}, Employee Age:{s1[2]}, Employee Salary:{s1[3]}");

            }

            return null;
        }

    }
}
