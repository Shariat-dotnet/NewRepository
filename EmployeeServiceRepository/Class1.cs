using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceRepository
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public decimal Salary { get; set; }
    }

   public class EContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EContext():base("newCon")
        {
            
        }
    }
}
