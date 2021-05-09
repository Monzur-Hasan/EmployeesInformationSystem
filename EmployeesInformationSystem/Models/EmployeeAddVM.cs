using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EmployeesInformationSystem.Model.Model;
using System.Web.Mvc;

namespace EmployeesInformationSystem.Models
{
    public class EmployeeAddVM
    {
        public int DepartmentId { get; set; }
        public List<Employee> Employees { get; set; }
        public List<SelectListItem> DepartmentList { get; set; }
    }
}