using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Models;
using RestaurantManagement.ViewModels;
using System;
using System.Numerics;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;
using System.Reflection.Metadata;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace RestaurantManagement.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private IEmployee2Repository _employeeRepository;
        public HomeController(IEmployee2Repository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route("/")] // or  [Route("~/")]  for navigating to root url when Route("Home") attribute already applied on Controller
        public IActionResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        [Route("Details/{id?}")]

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        //Model binding maps data in an HTTP request to controller action method parameters
        //The action parameters may be simple types such as integers, strings, etc or complex types like Customer, Employee, Order etc.
        public RedirectToActionResult Create(Employee2 employee)
        {
            Employee2 newEmployee=_employeeRepository.Add(employee);
            return RedirectToAction("Details",new { id=newEmployee.Id});
            //  When an HTTP request arrives at our MVC application it is the Controller action method that handles the incoming request.Let's say we want to view employee details whose ID is 2. For this we issue a GET request to the following URL
            //http://localhost:48118/home/details/2
            //The id value 2 in the request URL is mapped to the id parameter of the details(int? id) action method.

        }
    }
}
