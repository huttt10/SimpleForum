using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleForum.Data;
using SimpleForum.Models;

namespace SimpleForum.Controllers
{
    public class CreateForumController : Controller
    {
        private ApplicationDbContext DbContext;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateForum(Forum forum)
        {
            DbContext.Forums.Add(forum);
            DbContext.SaveChanges();

            return View();
        }
    }    
}
