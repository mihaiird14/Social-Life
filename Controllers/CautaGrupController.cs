using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social_Life.Data;
using Social_Life.Models;
using System.Linq;
using System.Threading;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Social_Life.Controllers
{
    public class CautaGrupController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _env;
        public CautaGrupController(ApplicationDbContext context,
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
        public async Task<IActionResult> New(Grup grup, IFormFile GrupImagine)
        {
            
            if (grup.GrupName == null)
            {
                TempData["EditTh"] = "Numele grupului este obligatoriu!";
                return RedirectToAction("Index", "CautaGrup");
            }
            if (grup.GrupName.Length < 5 || grup.GrupName.Length > 50)
            {
                TempData["EditTh"] = "Numele grupului trebuie sa fie intre 5 si 50 caractere!";
                return RedirectToAction("Index", "CautaGrup");
            }
            if (GrupImagine != null && GrupImagine.Length > 0)
            {
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
                var fileExtension = Path.GetExtension(GrupImagine.FileName).ToLower();
                if (!allowedExtensions.Contains(fileExtension))
                {
                    return View();
                }
                // Cale stocare
                var storagePath = Path.Combine(_env.WebRootPath, "grupuri", GrupImagine.FileName);
                var databaseFileName = "/grupuri/" + GrupImagine.FileName;
                using (var fileStream = new FileStream(storagePath, FileMode.Create))
                {
                    await GrupImagine.CopyToAsync(fileStream);
                }
                ModelState.Remove(nameof(grup.GrupImagine));
                grup.GrupImagine = databaseFileName;

            }
            else
            {
                grup.GrupImagine = "/imagini/grupDefault.png";
            }
            var profile = db.Profiles.FirstOrDefault(x => x.Id_User == grup.AdminGrupId);
            grup.Profile = profile;
            grup.DataGr = DateTime.Now;
            db.Grups.Add(grup);

            db.SaveChanges();
            var gm = new Grup_Membrii
            {
                UserId = profile.Id_User,
                GrupId = grup.GrupId,
                Data = DateTime.Now
            };
            db.Grup_Membriis.Add(gm);
            db.SaveChanges();
            return RedirectToAction("Index", "Grup", new { GrupId = grup.GrupId });
        }

        public IActionResult Search(string query)
        {

            TempData["RezultateSearch"] = db.Grups
                .Where(p => p.GrupName.Contains(query))
                .Select(p => p.GrupId)
                .ToList();
            return RedirectToAction("Index", "CautaGrup");
        }
        public IActionResult Search_Id(string Id)
        {

            TempData["RezultateSearch"] = db.Grups
            
                .Join(
                    db.Grup_Membriis,
                    grup => grup.GrupId,
                    membrii => membrii.GrupId,
                    (grup, membrii) => new { Grup = grup, Membrii = membrii }
                )
                .Where(g => g.Membrii.UserId == Id) 
                .Select(g => g.Grup.GrupId) 
                .Distinct() 
                .ToList();
            if (TempData["RezultateSearch"] == null)
            {
                TempData["nu"] = "nu";
            }
            return RedirectToAction("Index", "CautaGrup");
        }

    }
}
