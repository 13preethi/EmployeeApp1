using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary1
{
    interface IEmployee
    {
         void Add(Employee employee);
         void RemoveEmployee(Employee employee);
         void UpdateEmployee();
         Employee GetEmployeeById();
         Employee GetEmployeeByName();
         void GetAllEmployees();

    }
}
