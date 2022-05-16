using LibraryBusiness;
using LibraryWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LibraryWebApp.common;
using LbAssgLibrary;


namespace LibraryWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(Login logindata)
        {
            BSUsers bsuser = new BSUsers();
            DTOUser user = new DTOUser();
            UserModel model = new UserModel();
            if (ModelState.IsValid)
            {
                user = bsuser.ViewUser(logindata.username, logindata.password);
                model.username = user.username;
                model.firstname = user.firstname;
                model.lastname = user.lastname;
                model.emailid = user.emailid;
                model.password = user.password;
                model.phoneno = user.phoneno;
                model.pincode = user.pincode;
                model.streetaddress = user.streetaddress;
                model.city = user.city;
                model.role = user.role;
                model.accountstatus = user.accountstatus;
                if (user.role == "Administrator" || user.role == "Patron" || user.role == "Librarian" || user.role == "Guest")
                {
                    //HttpContext.Session.SetString("user", model.username);
                    // HttpContext.Session.SetString("role", model.role);
                    ViewBag.CurrentUser = model.username;
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "userObject", logindata);
                    //   logindata.password = null;
                    HttpContext.Session.SetString("User",logindata.username);
                    HttpContext.Session.SetInt32("userid", user.userid);
                    return RedirectToAction ("AdminView","Home", HttpContext.Session.GetString("User"));
                }
                else if (user.username == "NA")
                {
                    HttpContext.Session.SetString("user", model.username);
                    return RedirectToAction("AdminView", "Home");
                }
                else if (user.accountstatus == "Disabled")
                {
                    HttpContext.Session.SetString("user", model.username);
                    return RedirectToAction("AdminView", "Home");
                }
               

            }

            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
 
    }
}
