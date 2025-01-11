using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social_Life.Data;
using Social_Life.Models;
using System;

namespace Social_Life.Controllers
{
    public class GrupController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _env;
        public GrupController(ApplicationDbContext context,
                UserManager<ApplicationUser> userManager, IWebHostEnvironment env)
        {
            db = context;
            _userManager = userManager;
            _env = env;
        }
        public IActionResult Index(int GrupId)
        {
            var gr = db.Grups.FirstOrDefault(x => x.GrupId == GrupId);
            return View(gr);
        }
        [HttpPost]
        public IActionResult JoinGrup(string UserId, int GrupId)
        {
            var grm = new Grup_Membrii
            {
                UserId = UserId,
                GrupId=GrupId
            };
            db.Grup_Membriis.Add(grm);
            db.SaveChanges();
            var gr = db.Grups.FirstOrDefault(x => x.GrupId == GrupId);
            return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
        }
    }
}
