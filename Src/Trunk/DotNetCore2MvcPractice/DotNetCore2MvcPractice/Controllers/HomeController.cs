using System.Linq;
using DotNetCore2MvcPractice.Models;
using DotNetCore2MvcPractice.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore2MvcPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        
        // GET
        public IActionResult Index()
        {
            
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Pies = pies.ToList(),
                Title = "Welcome to Bethany's Pie Shop"
            };
            
            return View(homeViewModel);
        }
    }
}