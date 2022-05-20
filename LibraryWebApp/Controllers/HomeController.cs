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
    public class HomeController : Controller
    {
         private readonly ILogger<HomeController> _logger;

          public HomeController(ILogger<HomeController> logger)
          {
             _logger = logger;
          }

 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
         
      /* [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost] */
        public IActionResult Register(UserModel model)
        {
                BSUsers bsuser = new BSUsers();
                DTOUser user = new DTOUser();

            //  if (bsuser.checkuser(model.username) == 0)
            //  {

            if (ModelState.IsValid)
            {
                if (bsuser.checkuser(model.username) == 0)
                {
                    user.username = model.username;
                    user.firstname = model.firstname;
                    user.lastname = model.lastname;
                    user.emailid = model.emailid;
                    user.password = model.password;
                    user.phoneno = model.phoneno;
                    user.pincode = model.pincode;
                    user.streetaddress = model.streetaddress;
                    user.city = model.city;
                    user.loginlogoutstatus = "O";
                    user.accountstatus = "Enabled";
                    user.role = "Patron";


                    bsuser.Register(user);
                    int userid = bsuser.checkuser(model.username);
                    HttpContext.Session.SetString("User", user.username);
                    HttpContext.Session.SetInt32("userid", userid);
                    HttpContext.Session.SetString("userrole", user.role);
                    HttpContext.Session.SetString("userenabled", "Enabled");

                    return RedirectToAction("AdminView", "Home", user.username);
                }
                else
                {
                    TempData["Message"] = "User already exists, use another name";
                    return RedirectToAction("MessageDisplay", "Home");
                }

            }
            else
                return View();
                
               
          //  }
           /* else
            {
                TempData["Message"] = "User already exists, use another name";
                return RedirectToAction("MessageDisplay","Home");
            }*/
         //   return RedirectToAction("Index");
            
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
     
     [HttpGet]
        public IActionResult AdminView(string usrname)
        {
            BSUsers bsuser = new BSUsers();
            List<DTOUser> userlist = new List<DTOUser>();
            UserModel model = new UserModel();
            string loginname= HttpContext.Session.GetString("User");
            userlist.AddRange(bsuser.viewUser(loginname));
            foreach (var user in userlist)
            {
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
            }
            return View(model);
        }
        public ViewResult Role()
        {
            BSUsers bsuser = new BSUsers();
            List<DTORole> roles = new List<DTORole>();
            List<Role> modelrole= new List<Role>(); 
            roles.AddRange(bsuser.Viewrole());
            foreach (var rl in roles)
                modelrole.Add(new Role { roleid = rl.roleid, rolename = rl.role });
            return View(modelrole);
        }
        public ViewResult UserView()
        {
            BSUsers bsuser = new BSUsers();
            List<DTOUser> userdata = new List<DTOUser>();
            List<UserModel> modeluser = new List<UserModel>();
            userdata.AddRange(bsuser.ViewUserFull(""));
            foreach (var ul in userdata)
            {
                modeluser.Add(new UserModel
                {
                    username = ul.username,
                    firstname = ul.firstname,
                    lastname = ul.lastname,
                    emailid = ul.emailid,
                    password = ul.password,
                    phoneno = ul.phoneno,
                    pincode = ul.pincode,
                    streetaddress = ul.streetaddress,
                    city = ul.city,
                    loginlogoutstatus = ul.loginlogoutstatus,
                    accountstatus = ul.accountstatus,
                    role = ul.role,
                    userid=ul.userid
                });
      
            }
            return View(modeluser);
        }
                  
       
        public IActionResult catalogue(string cmedianame)
        {
            BSUsers bsu=new BSUsers();
            List<DTOMedia> media=new List<DTOMedia>();
            List<Catalogue> catmedia=new List<Catalogue>();
            string searchmedia = "";
            searchmedia = cmedianame;
            media.Clear();
            if(String.IsNullOrEmpty(searchmedia))
            {
                media.AddRange(bsu.search(""));
            }
            else 
                media.AddRange(bsu.search(cmedianame));
            foreach(DTOMedia mediaitem in media)
            {
                catmedia.Add(new Catalogue {mediaid=mediaitem.mediaid,medianame=mediaitem.medianame,mediagenre=mediaitem.mediagenre,
                mediaauthor=mediaitem.mediaauthor,numberofcopies=mediaitem.numberofcopies});
            }
 
                return View(catmedia);
        }

       /* [HttpPost]
        public void catalogue(IEnumerable<Catalogue> catmedia)
        {
            string mediacheck;
            foreach(var item in catmedia)
                mediacheck = item.mediacheck.ToString();    

        }*/

        public void checkout(List<Catalogue> model)
        {
            bool mediacheck;
            foreach (var item in model)
                mediacheck = item.mediacheck;
          

        }
        public ViewResult MessageDisplay()
        {
            ViewBag.Message = TempData["Message"];
                return View();
        }
        public ActionResult BacktoHome()
        {
            return  RedirectToAction("AdminView", "Home", HttpContext.Session.GetString("User"));
        }
    }
}
