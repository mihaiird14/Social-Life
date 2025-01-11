using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Social_Life.Data;
using Social_Life.Models;
using System.Security.Claims;

namespace Social_Life.Controllers
{
    public class ForYouController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;
        public ForYouController(ApplicationDbContext context,
                UserManager<ApplicationUser> userManager, IWebHostEnvironment env)
        {
            db = context;
            _userManager = userManager;
        }
       
        
            public async Task<ActionResult> Index()
            {

                var user = await _userManager.GetUserAsync(User);

                if (user == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                var userId = user.Id; 


               return View();
            }
        [HttpPost]
        public IActionResult NewCom(ThreadComment comentariu)
        {
            try
            {
                if (comentariu.CommentText == null)
                {
                    TempData["EditTh"] = "Comentariul este obligatoriu!";
                    return RedirectToAction("Index", "Profile");
                }
                var thread = db.Threads.FirstOrDefault(tl => tl.ThreadId == comentariu.ThreadId);
                var userId = _userManager.GetUserId(User);
                comentariu.Id_User = userId;
                comentariu.Date = DateTime.Now;
                thread.ThreadComments += 1;
                if (comentariu.CommentText.Length < 5 || comentariu.CommentText.Length > 100)
                {
                    TempData["EditTh"] = "Comentariul trebuie sa fie intre 5 si 100 caractere";
                    return RedirectToAction("Index", "Profile");
                }
                var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (comentariu.Id_User != currentUserId)
                {
                    var notificare = new Notification
                    {
                        Id_User = comentariu.Id_User, // Proprietarul postării
                        Id_User2 = currentUserId, // Cel care dă like
                        NotificationType = "Like",
                        Message = $"{User.Identity.Name} a lăsat un comentariu la un thread pe care l-ai postat!",
                        Date = DateTime.Now
                    };
                    db.Notifications.Add(notificare);
                }
                TempData["EditTh"] = null;
                db.ThreadComments.Add(comentariu);
                db.SaveChanges();
                return RedirectToAction("Index", "ForYou");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Profile");
            }
        }
        [HttpPost]
        public IActionResult DeleteCom(int ThreadCommentId)
        {

            var comentariu = db.ThreadComments.FirstOrDefault(t => t.ThreadCommentId == ThreadCommentId);
            var thread = db.Threads.FirstOrDefault(tl => tl.ThreadId == comentariu.ThreadId);
            if (comentariu == null)
            {
                return NotFound("Thread not found.");
            }
            thread.ThreadComments -= 1;
            db.ThreadComments.Remove(comentariu);
            db.SaveChanges();

            return RedirectToAction("Index", "ForYou");
        }
        [HttpPost]
        public IActionResult EditCom(ThreadComment comentariu)
        {
            var exCom = db.ThreadComments.FirstOrDefault(t => t.ThreadCommentId == comentariu.ThreadCommentId);
            if (exCom == null)
            {
                return NotFound("Thread not found.");
            }
            if (comentariu.CommentText == null)
            {
                TempData["EditTh"] = "Comentariul este obligatoriu!";
                return RedirectToAction("Index", "Profile");
            }
            if (comentariu.CommentText.Length < 5 || comentariu.CommentText.Length > 100)
            {
                TempData["EditTh"] = "Comentariul trebuie sa fie intre 5 si 100 caractere";
                return RedirectToAction("Index", "Profile");
            }
            TempData["EditTh"] = null;
            exCom.Edited = true;
            exCom.CommentText = comentariu.CommentText;
            db.SaveChanges();

            return RedirectToAction("Index", "ForYou");
        }
        [HttpPost]
        public IActionResult NewCom_Post(PostsComment comentariu)
        {
            try
            {
                if (comentariu.CommentText == null)
                {
                    TempData["EditTh"] = "Comentariul este obligatoriu!";
                    return RedirectToAction("Index", "Profile");
                }
                var postare = db.Postari.FirstOrDefault(tl => tl.Id == comentariu.PostId);
                var userId = _userManager.GetUserId(User);
                comentariu.Id_User = userId;
                comentariu.Date = DateTime.Now;
                if (comentariu.CommentText.Length < 5 || comentariu.CommentText.Length > 100)
                {
                    TempData["EditTh"] = "Comentariul trebuie sa fie intre 5 si 100 caractere";
                    return RedirectToAction("Index", "Profile");
                }

                postare.NrComentarii += 1;
                TempData["EditTh"] = null;
                db.PostsComments.Add(comentariu);
                db.SaveChanges();
                return RedirectToAction("Index", "ForYou");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Profile");
            }
        }
        [HttpPost]
        public IActionResult DeleteCom_Post(int PostCommentId)
        {

            var comentariu = db.PostsComments.FirstOrDefault(t => t.PostCommentId == PostCommentId);
            var post = db.Postari.FirstOrDefault(tl => tl.Id == comentariu.PostId);
            if (comentariu == null)
            {
                return NotFound("Thread not found.");
            }
            post.NrComentarii -= 1;
            db.PostsComments.Remove(comentariu);
            db.SaveChanges();

            return RedirectToAction("Index", "ForYou");
        }
        [HttpPost]
        public IActionResult EditCom_Post(PostsComment comentariu)
        {
            var exCom = db.PostsComments.FirstOrDefault(t => t.PostCommentId == comentariu.PostCommentId);
            if (exCom == null)
            {
                return NotFound("Thread not found.");
            }
            if (comentariu.CommentText == null)
            {
                TempData["EditTh"] = "Comentariul este obligatoriu!";
                return RedirectToAction("Index", "Profile");
            }
            if (comentariu.CommentText.Length < 5 || comentariu.CommentText.Length > 100)
            {
                TempData["EditTh"] = "Comentariul trebuie sa fie intre 5 si 100 caractere";
                return RedirectToAction("Index", "Profile");
            }
            TempData["EditTh"] = null;
            exCom.Edited = true;
            exCom.CommentText = comentariu.CommentText;
            db.SaveChanges();

            return RedirectToAction("Index", "ForYou");
        }
    }
}
    

