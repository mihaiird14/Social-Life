using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social_Life.Data;
using Social_Life.Models;

namespace Social_Life.Controllers
{
    public class ArhivaController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _env;
        public ArhivaController(ApplicationDbContext context,
                UserManager<ApplicationUser> userManager, IWebHostEnvironment env)
        {
            db = context;
            _userManager = userManager;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reposteaza(int Id)
        {
            var posts = db.Postari.FirstOrDefault(tl => tl.Id == Id);
            posts.Arhivat = false;
            db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
    }
}
