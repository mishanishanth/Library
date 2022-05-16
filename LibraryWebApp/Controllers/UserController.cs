using Microsoft.AspNetCore.Mvc;
using LibraryBusiness;
using LibraryWebApp.Models;
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
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditUser(int userid)
        {
            BSUsers bsuser = new BSUsers();
            DTOUser user = new DTOUser();
            List<DTORole> rolelist=new List<DTORole>();
            rolelist.AddRange(bsuser.Viewrole());
            UserModel model = new UserModel();
            user = bsuser.viewUser(userid);
            model.rolelist = new List<String>();    
              foreach (var rl in rolelist)
                model.rolelist.Add(rl.role);
            ViewBag.rolelist = model.rolelist;
            ViewBag.accountstatus = new List<String> { "Enabled", "Disabled" };
            model.userid = user.userid;
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
            return View(model);
        }
       [HttpPost]
       public ActionResult EditUser(UserModel model)
        {
            BSUsers bsuser = new BSUsers();
            DTOUser user = new DTOUser();
            List<DTORole> rolelist = new List<DTORole>();
            rolelist.AddRange(bsuser.Viewrole());
            model.rolelist = new List<String>();
            foreach (var rl in rolelist)
                model.rolelist.Add(rl.role);
            ViewBag.rolelist = model.rolelist;
            ViewBag.accountstatus=new List<String> {"Enabled", "Disabled"};
            user.userid = model.userid;
            user.username = model.username;
            user.firstname = model.firstname;
            user.lastname = model.lastname;
            user.emailid = model.emailid;
            user.password = model.password;
            user.phoneno = model.phoneno;
            user.pincode = model.pincode;
            user.streetaddress = model.streetaddress;
            user.city = model.city;
            user.role = model.role;
            user.accountstatus=model.accountstatus;
            bsuser.EditUser(user);
            ViewBag.message = "User Changes Submitted successfully";
            return RedirectToAction("UserView","Home");
        }

        [HttpGet]
        public IActionResult UserDetails(int userid)

        {
            BSUsers bsuser = new BSUsers();
            DTOUser user = new DTOUser();
            UserModel model = new UserModel();
            user = bsuser.viewUser(userid);
            model.userid = userid;
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


            return View(model);
        }

    }
}
