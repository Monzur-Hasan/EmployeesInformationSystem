using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeesInformationSystem.Models;
using EmployeesInformationSystem.BLL.BLL;
using EmployeesInformationSystem.Model.Model;
using AutoMapper;

namespace EmployeesInformationSystem.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager _employeeManager = new EmployeeManager();

        DistrictManager _districtManager = new DistrictManager();
        DepartmentManager _departmentManager = new DepartmentManager();

        [HttpGet]
        public ActionResult Add()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();

            employeeViewModel.DepartmentSelectList = _departmentManager.GetAllDepartments()
                                                      .Select(c => new SelectListItem
                                                      {
                                                          Value = c.Id.ToString(),
                                                          Text = c.Name
                                                      }).ToList();

            employeeViewModel.DistrictSelectList = _districtManager.GetAllDistricts()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.Id.ToString(),
                                                        Text = c.DistrictName
                                                    }).ToList();

            employeeViewModel.Employees = _employeeManager.GetAllEmployees();
            employeeViewModel.Employees = _employeeManager.GetAllEmployees2();
            return View(employeeViewModel);
        }

        [HttpPost]
        public ActionResult Add(EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                var employee = Mapper.Map<Employee>(employeeViewModel);


                if (_employeeManager.Add(employee))
                {
                    ViewBag.SuccessMsg = "Saved Successfully";
                }

                else
                {
                    ViewBag.ErrorMsg = "Not Saved!";
                }
            }
            else
            {
                ViewBag.ErrorMsg = "Model Failed!";
            }
            employeeViewModel.Employees = _employeeManager.GetAllEmployees();
            employeeViewModel.Employees = _employeeManager.GetAllEmployees2();

            employeeViewModel.DepartmentSelectList = _departmentManager.GetAllDepartments()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.Name
                                                     }).ToList();

            employeeViewModel.DistrictSelectList = _districtManager.GetAllDistricts()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.Id.ToString(),
                                                        Text = c.DistrictName
                                                    }).ToList();

            return View(employeeViewModel);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Employee employee = new Employee();

            employee.Id = Id;
            employee = _employeeManager.GetById(Id);

            var employeeViewModel = Mapper.Map<EmployeeViewModel>(employee);

            employeeViewModel.Employees = _employeeManager.GetAllEmployees();
            employeeViewModel.Employees = _employeeManager.GetAllEmployees2();

            employeeViewModel.DepartmentSelectList = _departmentManager.GetAllDepartments()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.Name
                                                     }).ToList();

            employeeViewModel.DistrictSelectList = _districtManager.GetAllDistricts()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.DistrictName
                                                     }).ToList();

            return View(employeeViewModel);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                var employee = Mapper.Map<Employee>(employeeViewModel);

                if (_employeeManager.Update(employee))
                {
                    ViewBag.SuccessMsg = "Updated Successfully";
                }
                else
                {
                    ViewBag.ErrorMsg = "Not Updated!";
                }
            }
            else
            {
                ViewBag.ErrorMsg = "Model Failed!";
            }

            employeeViewModel.Employees = _employeeManager.GetAllEmployees();
            employeeViewModel.Employees = _employeeManager.GetAllEmployees2();

            employeeViewModel.DepartmentSelectList = _departmentManager.GetAllDepartments()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.Name
                                                     }).ToList();

            employeeViewModel.DistrictSelectList = _districtManager.GetAllDistricts()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.DistrictName
                                                     }).ToList();

            return View(employeeViewModel);
        }

        //[HandleError(ExceptionType = typeof(Exception), View = "_Error")]
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            Employee employee = new Employee();
            employee.Id = Id;
            employee = _employeeManager.GetById(Id);

            EmployeeViewModel employeeViewModel = Mapper.Map<EmployeeViewModel>(employee);


            employeeViewModel.Employees = _employeeManager.GetAllEmployees();
            employeeViewModel.Employees = _employeeManager.GetAllEmployees2();

            employeeViewModel.DepartmentSelectList = _departmentManager.GetAllDepartments()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.Id.ToString(),
                                                        Text = c.Name
                                                    }).ToList();
            employeeViewModel.DistrictSelectList = _districtManager.GetAllDistricts()
                                                  .Select(c => new SelectListItem
                                                  {
                                                      Value = c.Id.ToString(),
                                                      Text = c.DistrictName
                                                  }).ToList();

            return View(employeeViewModel);
        }

        [HttpPost]
        public ActionResult Delete(EmployeeViewModel employeeViewModel)
        {

            if (ModelState.IsValid)
            {
                var employee = Mapper.Map<Employee>(employeeViewModel);

                if (_employeeManager.Delete(employee))
                {
                    ViewBag.SuccessMsg = "Deleted Successfully";
                }
                else
                {
                    ViewBag.ErrorMsg = "Not Deleted!";
                }
            }
            else
            {
                ViewBag.ErrorMsg = "Model Failed!";
            }

            employeeViewModel.Employees = _employeeManager.GetAllEmployees();
            employeeViewModel.Employees = _employeeManager.GetAllEmployees2();

            employeeViewModel.DepartmentSelectList = _departmentManager.GetAllDepartments()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.Name
                                                     }).ToList();

            employeeViewModel.DistrictSelectList = _districtManager.GetAllDistricts()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.DistrictName
                                                     }).ToList();

            return View(employeeViewModel);

        }

        //Search
        [HttpGet]
        public ActionResult Show()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.Employees = _employeeManager.GetAllEmployees();
            employeeViewModel.Employees = _employeeManager.GetAllEmployees2();

            employeeViewModel.DepartmentSelectList = _departmentManager.GetAllDepartments()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.Name
                                                     }).ToList();
            employeeViewModel.DistrictSelectList = _districtManager.GetAllDistricts()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.Id.ToString(),
                                                        Text = c.DistrictName
                                                    }).ToList();
            return View(employeeViewModel);
        }

        [HttpPost]
        public ActionResult Show(EmployeeViewModel employeeViewModel)
        {
            var employees = _employeeManager.GetAllEmployees();
            employees = _employeeManager.GetAllEmployees2();

            if (employeeViewModel.EmployeeId != null)
            {
                employees = employees.Where(c => c.EmployeeId.ToLower().Contains(employeeViewModel.EmployeeId.ToLower())).ToList();
            }
            if (employeeViewModel.Name != null)
            {
                employees = employees.Where(c => c.Name.ToLower().Contains(employeeViewModel.Name.ToLower())).ToList();
            }
            if (employeeViewModel.Email != null)
            {
                employees = employees.Where(c => c.Email.ToLower().Contains(employeeViewModel.Email.ToLower())).ToList();
            }
            if (employeeViewModel.Email != null)
            {
                employees = employees.Where(c => c.PhoneNo.ToLower().Contains(employeeViewModel.PhoneNo.ToLower())).ToList();
            }
            if (employeeViewModel.Address != null)
            {
                employees = employees.Where(c => c.Address.ToLower().Contains(employeeViewModel.Address.ToLower())).ToList();
            }
            if (employeeViewModel.Age > 0)
            {
                employees = employees.Where(c => c.Age == employeeViewModel.Age).ToList();
            }

            employeeViewModel.Employees = employees;

            employeeViewModel.DepartmentSelectList = _departmentManager.GetAllDepartments()
                                                     .Select(c => new SelectListItem
                                                     {
                                                         Value = c.Id.ToString(),
                                                         Text = c.Name
                                                     }).ToList();
            employeeViewModel.DistrictSelectList = _districtManager.GetAllDistricts()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.Id.ToString(),
                                                        Text = c.DistrictName
                                                    }).ToList();
            return View(employeeViewModel);
        }

        public JsonResult GetByDepartment(int departmentId)
        {
            var employess = _employeeManager.GetByDepartment(departmentId);
            return Json(employess, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details()
        {
            var departments = _departmentManager.GetAllDepartments()
                              .Select(c => new SelectListItem
                              {
                                  Value = c.Id.ToString(),
                                  Text = c.Name
                              }).ToList();

            departments.Insert(0, new SelectListItem()
            {
                Value = "",
                Text = "Select..."
            });

            ViewBag.Department = departments;
            return View();
        }
       
        public ActionResult GetEmployeeDetailsPartial(int employeeId)
        {
            var employee = _employeeManager.GetById(employeeId);

            return PartialView("Employee/_EmployeeView", employee);
        }


        [HttpGet]
        public ActionResult EmployeeAdd()
        {
            EmployeeAddVM employeeAddVM = new EmployeeAddVM();
            employeeAddVM.DepartmentList = _departmentManager.GetAllDepartments()
                                           .Select(c => new SelectListItem
                                           {
                                               Value = c.Id.ToString(),
                                               Text = c.Name
                                           }).ToList();
            return View(employeeAddVM);
        }

        [HttpPost]
        public ActionResult EmployeeAdd(EmployeeAddVM employeeAddVM)
        {
            var employees = new List<Employee>();

            if (ModelState.IsValid)
            {
                foreach (var employee in employeeAddVM.Employees)
                {
                    employee.DepartmentId = employeeAddVM.DepartmentId;
                    employees.Add(employee);
                }
            }

            _employeeManager.Add(employees);

            employeeAddVM.DepartmentList = _departmentManager.GetAllDepartments()
                                          .Select(c => new SelectListItem
                                          {
                                              Value = c.Id.ToString(),
                                              Text = c.Name
                                          }).ToList();

            return View(employeeAddVM);
        }
    }


}