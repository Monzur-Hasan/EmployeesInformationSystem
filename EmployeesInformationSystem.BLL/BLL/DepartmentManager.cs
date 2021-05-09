using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesInformationSystem.Repository.Repository;
using EmployeesInformationSystem.Model.Model;

namespace EmployeesInformationSystem.BLL.BLL
{
    public class DepartmentManager
    {
        DepartmentRepository _departmentRepository = new DepartmentRepository();

        public bool Add(Department department)
        {
            return _departmentRepository.Add(department);
        }

        public bool Update(Department department)
        {
            return _departmentRepository.Update(department);
        }

        public bool Delete(Department department)
        {
            return _departmentRepository.Delete(department);
        }

        public List<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAllDepartments();
                
        }

        public Department GetById(Department department)
        {
            return _departmentRepository.GetById(department);
        }
    }
}
