using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesInformationSystem.Model.Model;

namespace EmployeesInformationSystem.DatabaseContext.DatabaseContext
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
       // public DbSet<Address> Addresses { get; set; }
    }
}
