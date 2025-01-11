using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Social_Life.Data;
using Social_Life.Models;
using System.Security.Claims;

namespace Social_Life.Controllers
{
    public class Setari_GrupController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;
        public Setari_GrupController(ApplicationDbContext context,
                UserManager<ApplicationUser> userManager, IWebHostEnvironment env)
        {
            db = context;
            _userManager = userManager;
        }
        public IActionResult Index(int GrupId)
        {
            var gr = db.Grups.FirstOrDefault(x => x.GrupId == GrupId);
            return View(gr);
        }
        [HttpPost]
        public IActionResult SetarePublicGrup(int GrupId)
        {
            var gr = db.Grups.FirstOrDefault(x => x.GrupId == GrupId);
            if (gr == null)
            {
                return NotFound();
            }

            gr.GrupPublic = !gr.GrupPublic;

            db.SaveChangesAsync();

            return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
        }
        [HttpPost]
        public IActionResult StergeGrup(int GrupId)
        {
            var gr = db.Grups.FirstOrDefault(x => x.GrupId == GrupId);
            if (gr == null)
            {
                return NotFound();
            }
            db.Grups.Remove(gr);
            db.SaveChanges();
            return  RedirectToAction("Index", "CautaGrup");
        }
        [HttpPost]
        public IActionResult ParasesteGrup(int GrupId,string UserId)
        {
            var gr = db.Grups.FirstOrDefault(x => x.GrupId == GrupId);

            if (gr == null)
            {
                return NotFound();
            }
            var gm = db.Grup_Membriis.FirstOrDefault(x => x.GrupId == gr.GrupId && x.UserId == UserId);
            if (gm == null)
            {
                return NotFound();
            }
            db.Grup_Membriis.Remove(gm);
            db.SaveChanges();
            return RedirectToAction("Index", "CautaGrup");
        }
    }
}
