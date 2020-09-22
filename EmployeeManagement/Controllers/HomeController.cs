using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [Route("")]
        [Route("/")]
        [Route("[Action]")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetEmployees();
            return View(model);
        }
        [Route("[Action]/{id?}")]
        public ViewResult Details(int? id)
        {
            var ViewModel = new HomeDetailViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle="Employee's Details"
            };
            return View(ViewModel);
        }
    }
}
