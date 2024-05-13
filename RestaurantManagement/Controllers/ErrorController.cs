using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestaurantManagement.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        // Inject ASP.NET Core ILogger service. Specify the Controller
        // Type as the generic parameter. This helps us identify later
        // which class or controller has logged the exception
        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger;
        }
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult =
                    HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource could not be found";
                    ViewBag.Path = statusCodeResult.OriginalPath;
                    ViewBag.QS = statusCodeResult.OriginalQueryString;
                   
                    // LogWarning() method logs the message under
                    // Warning category in the log
                    logger.LogWarning($"404 error occured. Path = " +
                        $"{statusCodeResult.OriginalPath} and QueryString = " +
                        $"{statusCodeResult.OriginalQueryString}");
                    break;
            }

            return View("NotFound");
        }
        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            // Retrieve the exception Details
            var exceptionHandlerPathFeature =
                    HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExceptionPath = exceptionHandlerPathFeature.Path;
            ViewBag.ExceptionMessage = exceptionHandlerPathFeature.Error.Message;
            ViewBag.StackTrace = exceptionHandlerPathFeature.Error.StackTrace;
            // LogError() method logs the exception under Error category in the log
            logger.LogError($"The path {exceptionHandlerPathFeature.Path} " + $"threw an exception {exceptionHandlerPathFeature.Error}");
          

            return View("Error");
        }
    }

}
