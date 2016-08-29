using Blog_MVCProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace Blog_MVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var posts = db.Posts.OrderByDescending(p => p.Date).Take(3);

            return View(posts.ToList());
        }
    }
}