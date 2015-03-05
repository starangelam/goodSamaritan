using GoodSamaritan.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UsersController : Controller
    {
        ApplicationDbContext ctx = new ApplicationDbContext();
        UserManager<ApplicationUser> _userManager;

        public UserManager<ApplicationUser> UserManager
        {
            get
            {
                if (_userManager == null)
                {
                    var userStore = new UserStore<ApplicationUser>(ctx);
                    _userManager = new UserManager<ApplicationUser>(userStore);
                }
                return _userManager;
            }
            private set {
                _userManager = value;
            }
        }

        // GET: Users
        public ActionResult Index()
        {
            var users = ctx.Users.ToList();
            return View(users);
        }

        // GET: Users/Roles/5
        public ActionResult ManageRoles(string id)
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
            ViewBag.user = user;
            ViewBag.currRoles = UserManager.GetRoles(id);

            return View();
        }

        [HttpPost, ActionName("Remove")]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveRoleFromUser(string userId, string roleName)
        {
            if (roleName == null || userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }



            return RedirectToAction("Index");
            //return View("ManageRoles");
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