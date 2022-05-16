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
        // private readonly ILogger<HomeController> _logger;

        //  public HomeController(ILogger<HomeController> logger)
        //  {
        //      _logger = logger;
        //  }

 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]

        //*Added now for session 
   
   /*     public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login logindata)
        {
            BSUsers bsuser = new BSUsers();
            DTOUser user = new DTOUser();
            UserModel model=new UserModel();

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


                if (user.role == "Administrator" || user.role=="Patron" || user.role=="Librarian" || user.role=="Guest")
                {
                    //HttpContext.Session.SetString("user", model.username);
                    // HttpContext.Session.SetString("role", model.role);
                    ViewBag.CurrentUser = model.username;
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "userObject", logindata);


                }
                else if (user.username =="NA")
                {
                    HttpContext.Session.SetString("user", model.username);
                  //  HttpContext.Session.SetString("role", model.role);
                  
                }
                else if(user.accountstatus =="Disabled")
                {
                    HttpContext.Session.SetString("user", model.username);
                }
               
                
            }
             return View("AdminView", model);
           // return RedirectToAction("AdminView", model);
        }
        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            // HttpContext.Session.SetString("role", null);
            // return RedirectToAction("Index");
            return View("Logout");
        } */
       [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserModel model)
        {
                BSUsers bsuser = new BSUsers();
                DTOUser user = new DTOUser();
                
                if (ModelState.IsValid)
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

                }
                return View();
               // return RedirectToAction("Index");
            
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
     /*   public IActionResult AdminView(UserModel user)
        {
            ViewBag.CurrentUser = User;
            return View(user);
        }*/
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

        [HttpPost]
        public void catalogue(IEnumerable<Catalogue> catmedia)
        {
            string mediacheck;
            foreach(var item in catmedia)
                mediacheck = item.mediacheck.ToString();    

        }

        public void checkout(List<Catalogue> model)
        {
            bool mediacheck;
            foreach (var item in model)
                mediacheck = item.mediacheck;
          

        }
    }
}
