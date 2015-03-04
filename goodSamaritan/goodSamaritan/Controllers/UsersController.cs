using GoodSamaritan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles="Administrator")]
    public class UsersController : Controller
    {
        ApplicationDbContext ctx = new ApplicationDbContext();

        // GET: Users
        public ActionResult Index()
        {
            var users = ctx.Users.ToList();
            return View(users);
        }

        // GET: Users/Disable/5
        public ActionResult Disable(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = ctx.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Disable/5
        [HttpPost, ActionName("Disable")]
        [ValidateAntiForgeryToken]
        public ActionResult DisableConfirmed(string id)
        {
            //AccountController account = new AccountController();
            //account.UserManager.RemovePasswordAsync(id);

            return RedirectToAction("Index");
        }
    }
}