using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EmployeesInformationSystem.Model.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
      
        public string Address { get; set; }
        public int Age { get; set; }
        public double BasicSalary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}
