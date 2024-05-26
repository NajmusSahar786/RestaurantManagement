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
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace RestaurantManagement.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IEmployee2Repository _employeeRepository;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;
        private readonly ILogger<HomeController> logger;
        public HomeController(IEmployee2Repository employeeRepository,Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment, ILogger<HomeController> logger)
        {
            _employeeRepository = employeeRepository;
            this._hostingEnvironment = hostingEnvironment;
            this.logger = logger;
        }

        [Route("/")] // or  [Route("~/")]  for navigating to root url when Route("Home") attribute already applied on Controller
        public IActionResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public async Task<IActionResult> Employee()
        {
            var employees =  _employeeRepository.GetAllEmployee();
            return View(employees);
        }

        [Route("Details/{id?}")]

        public ViewResult Details(int? id)
        {
            //throw new Exception("Error in Details View");//We are deliberately throwing an exception using the throw keyword.
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");
            Employee2 employee = _employeeRepository.GetEmployee(id.Value);

            if (employee == null)
            {
                Response.StatusCode = 404;
                return View("EmployeeNotFound",id.Value);
            }
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = employee,
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
        public IActionResult Create(EmployeeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                uniqueFileName = ProcessUploadedFile(model);

                Employee2 newEmployee = new Employee2
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    PhotoPath = uniqueFileName
                };

                _employeeRepository.Add(newEmployee);
                return RedirectToAction("details", new { id = newEmployee.Id });
            }
            return View();
        }

        [HttpGet]
        

        public ViewResult Edit(int id)
        {
            Employee2 employee = _employeeRepository.GetEmployee(id);
            EmployeeEditViewModel employeeEditViewModel = new EmployeeEditViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department,
                ExistingPhotoPath = employee.PhotoPath
            };
            return View(employeeEditViewModel);
        }

        // Through model binding, the action method parameter
        // EmployeeEditViewModel receives the posted edit form data
        [HttpPost]
        
        public IActionResult Edit(EmployeeEditViewModel model)
        {
            // Check if the provided data is valid, if not rerender the edit view
            // so the user can correct and resubmit the edit form
            if (ModelState.IsValid)
            {
                // Retrieve the employee being edited from the database
                Employee2 employee = _employeeRepository.GetEmployee(model.Id);
                // Update the employee object with the data in the model object
                employee.Name = model.Name;
                employee.Email = model.Email;
                employee.Department = model.Department;

                // If the user wants to change the photo, a new photo will be
                // uploaded and the Photo property on the model object receives
                // the uploaded photo. If the Photo property is null, user did
                // not upload a new photo and keeps his existing photo
                if (model.Photo != null)
                {
                    // If a new photo is uploaded, the existing photo must be
                    // deleted. So check if there is an existing photo and delete
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath,
                            "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    // Save the new photo in wwwroot/images folder and update
                    // PhotoPath property of the employee object which will be
                    // eventually saved in the database
                    employee.PhotoPath = ProcessUploadedFile(model);
                }

                // Call update method on the repository service passing it the
                // employee object to update the data in the database table
                Employee2 updatedEmployee = _employeeRepository.Update(employee);

                return RedirectToAction("index");
            }

            return View(model);
        }

        private string ProcessUploadedFile(EmployeeCreateViewModel model)
        {
            string uniqueFileName = null;

            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

    }
}
