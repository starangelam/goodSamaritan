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
    public class RolesController : Controller
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
            private set
            {
                _userManager = value;
            }
        }

        // GET: Roles
        public ActionResult Index()
        {
            var roles = ctx.Roles.ToList();
            return View(roles);
        }

        // GET: /Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Roles/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                ctx.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
                {
                    Name = collection["RoleName"]
                });

                ctx.SaveChanges();

                ViewBag.ResultMessage = "Role created successfully !";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Roles/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var role = ctx.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var role = ctx.Roles.Find(id);
            ctx.Roles.Remove(role);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: ManageUserRoles
        public ActionResult ManageUserRoles()
        {
            ViewBag.Roles = from r in ctx.Roles
                            orderby r.Name
                            select new SelectListItem { Value = r.Id, Text = r.Name };

            ViewBag.Users = from u in ctx.Users
                            orderby u.UserName
                            select new SelectListItem { Value = u.Id, Text = u.UserName };
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ShowUserRoles(string userId)
        {
            if (userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = ctx.Users.Find(userId);
            if (user == null)
            {
                return HttpNotFound();
            }

            ViewBag.UserName = user.UserName;
            ViewBag.Roles = UserManager.GetRoles(userId);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUserToRole(string roleId, string userId)
        {
            if (roleId == null || userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = ctx.Users.Find(userId);
            var role = ctx.Roles.Find(roleId);
            if (user == null || role == null)
            {
                return HttpNotFound();
            }

            if (UserManager.IsInRole(userId, role.Name))
            {
                ViewBag.ErrorMsg = String.Format("This user already belong to selected role \"{0}\".",
                    role.Name);

            }
            else
            {
                UserManager.AddToRole(userId, role.Name);

                ViewBag.SuccessMsg = String.Format("Role \"{0}\" added to this user successfully!",
                    role.Name);
            }
            ViewBag.UserName = user.UserName;
            ViewBag.Roles = UserManager.GetRoles(userId);

            return View("ShowUserRoles");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveUserFromRole(string roleId, string userId)
        {
            if (roleId == null || userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = ctx.Users.Find(userId);
            var role = ctx.Roles.Find(roleId);
            if (user == null || role == null)
            {
                return HttpNotFound();
            }

            if (UserManager.IsInRole(userId, role.Name))
            {
                if (User.Identity.Name == user.UserName && role.Name == "Administrator")
                {
                    ViewBag.ErrorMsg = String.Format("You cannot remove \"{0}\" role from yourself!",
                        role.Name);
                }
                else
                {
                    UserManager.RemoveFromRole(userId, role.Name);
                    ViewBag.SuccessMsg = String.Format("Role \"{0}\" removed from this user successfully!",
                        role.Name);
                }

            }
            else
            {
                ViewBag.ErrorMsg = String.Format("This user doesn't belong to selected role \"{0}\".",
                    role.Name);
            }

            ViewBag.UserName = user.UserName;
            ViewBag.Roles = UserManager.GetRoles(userId);

            return View("ShowUserRoles");
        }

        // GET: DisableUser
        [ActionName("Disable")]
        public ActionResult DisableUser()
        {
            ViewBag.Users = from u in ctx.Users
                            orderby u.UserName
                            select new SelectListItem { Value = u.Id, Text = u.UserName };

            return View();
        }

        [HttpPost, ActionName("Disable")]
        [ValidateAntiForgeryToken]
        public ActionResult DisableUser(string id)
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

            if (User.Identity.Name != user.UserName)
            {
                if (!UserManager.IsLockedOut(id))
                {
                    UserManager.SetLockoutEnabled(id, true);
                    UserManager.SetLockoutEndDate(id, DateTime.UtcNow.AddYears(100));
                    UserManager.Update(user);
                    ViewBag.SuccessMsg = String.Format("User \"{0}\" disabled successfully!", user.UserName);
                }
                else
                {
                    ViewBag.ErrorMsg = String.Format("User \"{0}\" already disabled!", user.UserName);
                }
            }
            else
            {
                ViewBag.ErrorMsg = "You cannot disable yourself!";
            }

            ViewBag.Users = from u in ctx.Users
                            orderby u.UserName
                            select new SelectListItem { Value = u.Id, Text = u.UserName };

            return View("Disable");
        }

        [HttpPost, ActionName("Enable")]
        [ValidateAntiForgeryToken]
        public ActionResult EnableUser(string id)
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

            if (UserManager.IsLockedOut(id))
            {
                UserManager.SetLockoutEnabled(id, false);
                UserManager.Update(user);
                ViewBag.SuccessMsg = String.Format("User \"{0}\" enabled successfully!", user.UserName);
            }
            else
            {
                ViewBag.ErrorMsg = String.Format("User \"{0}\" is enabled!", user.UserName);
            }

            ViewBag.Users = from u in ctx.Users
                            orderby u.UserName
                            select new SelectListItem { Value = u.Id, Text = u.UserName };

            return View("Disable");
        }
    }
}