using DotNetCore2MvcPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore2MvcPractice.Controllers
{
    public class FeedbackController : Controller
    {
        public FeedbackController()
        {
        }


        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                // Save to Database (Service or Repository)
                return RedirectToAction("FeedbackComplete");
            }
            return View(feedback);
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }

    }
}