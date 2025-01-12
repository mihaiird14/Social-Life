using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Social_Life.Data;
using Social_Life.Models;
using System;
using System.Security.Claims;
using System.Threading;

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
            var gr = db.Grups.FirstOrDefault(x => x.GrupId == GrupId);
            if (gr.GrupPublic == true)
            {
                var grm = new Grup_Membrii
                {
                    UserId = UserId,
                    GrupId = GrupId
                };
                db.Grup_Membriis.Add(grm);
                db.SaveChanges();

                return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
            }
            else
            {
                var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var notificare = new NotificaticareGrup
                {
                    Id_User = currentUserId,
                    GrupId = GrupId,
                    NotificationType = "Request_Grup",
                    Message = $"{User.Identity.Name} doreste să intre în grupul {gr.GrupName}",
                    Date = DateTime.Now
                };
                db.NotificaticareGrups.Add(notificare);
                db.SaveChanges();
                return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
            }            
        }
        [HttpGet]
        public IActionResult SearchGM(string query,int GrupId)
        {
            if (string.IsNullOrEmpty(query))
            {
                TempData["ListaGM"] = null;
                
            }
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var results = db.Profiles
                .Where(p => db.Grup_Membriis
                    .Any(g => g.GrupId == GrupId && g.UserId == p.Id_User) &&
                            (p.Username.Contains(query) || p.Nume.Contains(query) || p.Prenume.Contains(query)))
                .OrderBy(p => p.Username)
                .ToList();



            ViewBag.Query = query;
            TempData["ListaGM"] = JsonConvert.SerializeObject(results);
            return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
        }
        [HttpPost]
        public async Task<IActionResult> AddPostGr(string TextPostGr,IFormFile imagine,int GrupId, string UserId)
        {

            if (imagine != null && imagine.Length > 0)
            {
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
                var fileExtension = Path.GetExtension(imagine.FileName).ToLower();
                if (!allowedExtensions.Contains(fileExtension))
                {
                    return View();
                }
                // Cale stocare
                var storagePath = Path.Combine(_env.WebRootPath, "postariGrup", imagine.FileName);
                var databaseFileName = "/postariGrup/" + imagine.FileName;
                using (var fileStream = new FileStream(storagePath, FileMode.Create))
                {
                    await imagine.CopyToAsync(fileStream);
                }
                if (TextPostGr == null)
                {
                    TempData["EditTh"] = "Textul este obligatoriu!";
                    return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
                }
                if (TextPostGr.Length < 5 || TextPostGr.Length > 100)
                {
                    TempData["EditTh"] = "Textul trebuie sa fie intre 5 si 100 caractere";
                    return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
                }
                var postare = new PostareGrup
                {
                    UserId = UserId,
                    GrupId = GrupId,
                    Imagine = databaseFileName,
                    Text = TextPostGr,
                    Data = DateTime.Now
                };
                db.PostareGrups.Add(postare);
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
            }

            else
            {
                if (TextPostGr == null)
                {
                    TempData["EditTh"] = "Textul este obligatoriu!";
                    return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
                }
                if (TextPostGr.Length < 5 || TextPostGr.Length > 100)
                {
                    TempData["EditTh"] = "Textul trebuie sa fie intre 5 si 100 caractere";
                    return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
                }
                var postare = new PostareGrup
                {
                    UserId = UserId,
                    GrupId = GrupId,
                    Imagine = null,
                    Text = TextPostGr,
                    Data = DateTime.Now
                };
                db.PostareGrups.Add(postare);
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
            }
           
        }
        [HttpPost]
        public IActionResult DeletePostGr(int PostGrId, int GrupId)
        {

            var post = db.PostareGrups.FirstOrDefault(t => t.Id == PostGrId);

            if (post == null)
            {
                return NotFound("Thread not found.");
            }

            db.PostareGrups.Remove(post);
            db.SaveChanges();

            return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
        }
        [HttpPost]
        public IActionResult EditPostGr(int PostGrId, string PostGrText, int GrupId)
        {
            var post = db.PostareGrups.FirstOrDefault(t => t.Id == PostGrId);
            if (post == null)
            {
                return NotFound("Thread not found.");
            }
            post.Text = PostGrText;
            if (post.Text == null)
            {
                TempData["EditTh"] = "Textul este obligatoriu!";
                return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
            }
            if (post.Text.Length < 5 || post.Text.Length > 100)
            {
                TempData["EditTh"] = "Textul trebuie sa fie intre 5 si 100 caractere";
                return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
            }
            TempData["EditTh"] = null;
            db.SaveChanges();

            return RedirectToAction("Index", "Grup", new { GrupId = GrupId });
        }
    }
    
}
