using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using EmployeesInformationSystem.Model.Model;
using EmployeesInformationSystem.Models;

namespace EmployeesInformationSystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ConfigurationManager();
        }

        public void ConfigurationManager()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeViewModel>();
                cfg.CreateMap<EmployeeViewModel, Employee>();
            });
        }
    }
}
