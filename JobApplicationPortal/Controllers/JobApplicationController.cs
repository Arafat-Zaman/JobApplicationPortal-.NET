using Microsoft.AspNetCore.Mvc;
using JobApplicationPortal.Models;
using System.IO;

namespace JobApplicationPortal.Controllers
{
    public class JobApplicationController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(JobApplication application)
        {
            if (ModelState.IsValid)
            {
                // Save resume file to wwwroot/resumes
                if (application.Resume != null)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/resumes", application.Resume.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        application.Resume.CopyTo(stream);
                    }
                }

                // On success, redirect to Success page
                return RedirectToAction("Success");
            }

            // If the model is invalid, return to form with validation errors
            return View(application);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
