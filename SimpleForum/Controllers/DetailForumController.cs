using Microsoft.AspNetCore.Mvc;
using SimpleForum.Data;
using SimpleForum.Models;

namespace SimpleForum.Controllers
{
    public class DetailForumController : Controller
    {
        private ApplicationDbContext _dbContext;

        public DetailForumController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int idForum)
        {
            Forum forum = _dbContext.Forums.SingleOrDefault(x => x.Id == idForum);
            
            return View(forum);
        }
    }
}
