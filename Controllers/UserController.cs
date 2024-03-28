using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryMSMVC.Models;

namespace LibraryMSMVC.Controllers
{
    public class UserController : Controller
    {
        UserEntity userDb = new UserEntity();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(tblUser user)
        {
            var adm = userDb.tblUsers.SingleOrDefault(a => a.UserEmail == user.UserEmail && a.UserPass == user.UserPass);
            if (adm != null)
            {
                Session["userId"] = adm.UserId;
                Session["userName"] = adm.UserName;
                return RedirectToAction("Index", "Borrow", new { userId = adm.UserId, userName = adm.UserName });
            }
            else if (user.UserEmail == null && user.UserPass == null)
            {
                return View();
            }
            ViewBag.Message = "User name and password are not matching";
            return View();
        }

        
        // User logout, redirect to main. 
        public ActionResult Logout()
        {
            Session.Remove("userId");
            Session.Remove("userName");
            return RedirectToAction("Home", "Main");
        }
    }
}