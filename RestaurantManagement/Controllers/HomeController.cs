using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Models;

namespace RestaurantManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public ViewResult Details(int? id)
        {
            Employee model = _employeeRepository.GetEmployee(id ?? 1);
            ViewData["Employee"] = model;
            ViewData["PageTitle"] = "Employee Details";
            return View();
        }
    }
}
