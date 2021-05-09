using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EmployeesInformationSystem.Model.Model;
using EmployeesInformationSystem.DatabaseContext.DatabaseContext;
using System.Configuration;
using System.Data.Entity;

namespace EmployeesInformationSystem.Repository.Repository
{
    public class EmployeeRepository
    {
        EmployeeDbContext _dbContext = new EmployeeDbContext();
        public bool Add(Employee employee)
        {
            int isExecuted = 0;

            _dbContext.Employees.Add(employee);
            isExecuted = _dbContext.SaveChanges();

            if(isExecuted > 0)
            {
                return true;
            } 
            return false;
        }
      
        
        public bool Add(List<Employee> employees)
        {
            int isExecuted = 0;
            _dbContext.Employees.AddRange(employees);

            isExecuted = _dbContext.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Employee employee)
        {
            try
            {
                int isExecuted = 0;

                Employee aEmployee = _dbContext.Employees.FirstOrDefault(c => c.Id == employee.Id);
                _dbContext.Employees.Remove(aEmployee);
                isExecuted = _dbContext.SaveChanges();

                if (isExecuted > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool Update(Employee employee)
        {
            int isExecuted = 0;
            //Employee aEmployee = _dbContext.Employees.FirstOrDefault(c => c.Id == employee.Id);

            _dbContext.Entry(employee).State = EntityState.Modified;
            isExecuted = _dbContext.SaveChanges();
            if(isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.Include(c => c.Department).ToList();
        }

        public List<Employee> GetAllEmployees2()
        {
            return _dbContext.Employees.Include(c => c.District).ToList();
        }

        public Employee GetById(int employeeId)
        {
            Employee aEmployee = _dbContext.Employees.FirstOrDefault(c => c.Id == employeeId);
            return aEmployee;
        }

        public List<Employee> GetByDepartment(int departmentId)
        {
            return _dbContext.Employees.Where(c => c.DepartmentId == departmentId).ToList();
        }
    }
}

