using Microsoft.AspNetCore.Mvc;
using SimpleForum.Data;
using SimpleForum.Models;

namespace SimpleForum.Controllers
{
    public class DetailForumController : Controller
    {
        private ApplicationDbContext dbContext;
        public IActionResult Index(int idForum)
        {
            Forum forum = dbContext.Forums.SingleOrDefault(x => x.Id == idForum);
            
            return View(forum);
        }
    }
}
