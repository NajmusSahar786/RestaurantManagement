using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Models;
using RestaurantManagement.ViewModels;

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
    }
}
