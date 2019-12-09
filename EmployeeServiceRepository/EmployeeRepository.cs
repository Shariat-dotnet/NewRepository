using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeServiceRepository
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeRepository" in both code and config file together.
    public class EmployeeRepository : IEmployeeRepository
    {
       EContext db =new EContext();

        public List<Employee> GetEmployees()
        {
           var employee= db.Employees.ToList();
           return employee;
        }

        public Employee GetEmployee(int id)
        {
            var employee = db.Employees.Find(id);
            return employee;
        }

        public Employee CreateEmployees(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployees(Employee employee)
        {
            db.Entry(employee).State=EntityState.Modified;
            db.SaveChanges();
            return employee;
        }
    }
}
