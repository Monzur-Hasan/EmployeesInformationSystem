using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesInformationSystem.Model.Model;
using EmployeesInformationSystem.Repository.Repository;

namespace EmployeesInformationSystem.BLL.BLL
{
    public class EmployeeManager
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public bool Add(Employee employee)
        {
            return _employeeRepository.Add(employee);
        }

        public bool Add(List<Employee> employees)
        {
            return _employeeRepository.Add(employees);
        }

        public bool Delete(Employee employee)
        {
            return _employeeRepository.Delete(employee);
        }

        public bool Update(Employee employee)
        {
            return _employeeRepository.Update(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public List<Employee> GetAllEmployees2()
        {
            return _employeeRepository.GetAllEmployees2();
        }

        public Employee GetById(int employeeId)
        {
            return _employeeRepository.GetById(employeeId);
        }

        public List<Employee> GetByDepartment(int departmentId)
        {
            return _employeeRepository.GetByDepartment(departmentId);
        }
    }
}
