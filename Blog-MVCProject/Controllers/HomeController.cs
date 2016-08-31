using Blog_MVCProject.Models;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace Blog_MVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var posts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date);

            return View(posts.ToList());
        }

        public ActionResult Users()
        {
            var db = new ApplicationDbContext();

            var users = db.Users.OrderBy(u => u.UserName);

            return View(users.ToList());
        }
    }
}