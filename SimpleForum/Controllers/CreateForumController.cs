using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleForum.Data;
using SimpleForum.Models;

namespace SimpleForum.Controllers
{
    public class CreateForumController : Controller
    {
        private ApplicationDbContext _dbContext;
        
        public CreateForumController(ApplicationDbContext DbContext)
        {
            _dbContext = DbContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateForum(Forum forum)
        {
            _dbContext.Forums.Add(forum);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }    
}
