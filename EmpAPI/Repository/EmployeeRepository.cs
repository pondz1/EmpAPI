using EmpAPI.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EmpAPI.Repository
{

    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeContext context;

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            context = employeeContext;
        }
        public void DeleteEmployee(int employeeId)
        {
            Employee employee = context.Employees.Find(employeeId);
            context.Employees.Remove(employee);
        }

        public Employee GetEmployeeByID(int employeeId)
        {
            return context.Employees.Find(employeeId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            context.Employees.Add(employee);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            context.Entry(employee).State = EntityState.Modified;
        }
    }
}
