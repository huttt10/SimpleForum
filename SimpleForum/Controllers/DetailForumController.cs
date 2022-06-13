using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleForum.Data;
using SimpleForum.Models;
using SimpleForum.Models.ViewModels;
using System.Security.Claims;

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
            List<Contribution> listOfContribution = _dbContext.Contributions.Where(x => x.ForumForeignKey == idForum).ToList();            

            DetailForumViewModel viewModel = new DetailForumViewModel();
            viewModel.Forum = forum;
            viewModel.Contribution = listOfContribution;

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddContribution(int idForum, string content)
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            Contribution contribution = new Contribution();

            if(idForum != 0)
            {
                contribution.UserId = claim.Value;
                contribution.ForumForeignKey = idForum;
                contribution.Contetent = content;            
            }

            _dbContext.Contributions.Add(contribution);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", new { idForum });            
        }
    }
}
