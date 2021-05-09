using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesInformationSystem.Model.Model;
using EmployeesInformationSystem.DatabaseContext.DatabaseContext;
using System.Data.Entity;

namespace EmployeesInformationSystem.Repository.Repository
{
    public class DepartmentRepository
    {
        EmployeeDbContext _dbContext = new EmployeeDbContext();
        public bool Add(Department department)
        {
            int isExecuted = 0;
            _dbContext.Departments.Add(department);
            isExecuted = _dbContext.SaveChanges();

            if(isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(Department department)
        {
            int isExecuted = 0;
            _dbContext.Entry(department).State = EntityState.Modified;
            isExecuted = _dbContext.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Department department)
        {
            int isExecuted = 0;
            Department aDepartment = _dbContext.Departments.FirstOrDefault(c => c.Id == department.Id);
            _dbContext.Departments.Remove(aDepartment);
          
            isExecuted = _dbContext.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public List<Department> GetAllDepartments()
        {
            return _dbContext.Departments.ToList();
        }

        public Department GetById(Department department)
        {
            Department aDepartment = _dbContext.Departments.FirstOrDefault(c => c.Id == department.Id);
            return aDepartment;
        }
    }
}
