using EmpAPI.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpAPI.Repository
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeByID(int employeeId);
        void InsertEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        void UpdateEmployee(Employee employee);
        void Save();
    }
}
