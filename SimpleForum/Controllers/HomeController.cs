using Microsoft.AspNetCore.Mvc;
using SimpleForum.Data;
using SimpleForum.Models;
using System.Diagnostics;

namespace SimpleForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext dbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Forum> tableForum = new List<Forum>();
            if(dbContext != null)
            {
                tableForum = dbContext.Forums.ToList();
            }
            return View(tableForum);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}