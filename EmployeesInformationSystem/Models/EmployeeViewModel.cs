using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeesInformationSystem.Model.Model;

namespace EmployeesInformationSystem.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Id can not be Empty")]
        [Display(Name = "Employee Id")]
        public string EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee Name can not be Empty")]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string PhoneNo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Basic Salary")]
        public double BasicSalary { get; set; }

        [Required(ErrorMessage = "Department can not be Empty")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [Required(ErrorMessage = "District can not be Empty")]
        [Display(Name = "District")]
        public int DistrictId { get; set; }
        public District District { get; set; }

        public List<Employee> Employees { get; set; }

        public IEnumerable<SelectListItem> DepartmentSelectList { get; set; }  //Dropdown
        public List<SelectListItem> DistrictSelectList { get; set; }

    }
}