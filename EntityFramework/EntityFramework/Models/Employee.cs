using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFramework.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
    }
    public class EmployeeContext : Employee
    {
        public DbSet<Employee> Employees { get; set; }
    }
}