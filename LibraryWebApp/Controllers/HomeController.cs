using LibraryBusiness;
using LibraryWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Login(Login logindata)
        {
            BSUsers bsuser = new BSUsers();
            DTOUser user = new DTOUser();
            UserModel model=new UserModel();

           // if (!ModelState.IsValid)
           // {
                user=bsuser.ViewUser(logindata.username, logindata.password);
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


               if( user.role == "Administrator")
                 {
                    return View("AdminView",model);
                 }
              else
                {
                    return View ("Index");
                }
            

        }
       [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            try
            {
                BSUsers bsuser = new BSUsers();
                DTOUser user = new DTOUser();
                //  DTOUser user1 = new DTOUser();
                //  user1.username = "ntest";
                //  bsuser.Register(user1);
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
                    user.accountstatus = "O";
                    user.role = "Guest";
                    bsuser.Register(user);

                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AdminView()
        {
            return View();
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
              
        [HttpGet]
        public ViewResult catalogue(string cmedianame)
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
                catmedia.Add(new Catalogue {medianame=mediaitem.medianame,mediagenre=mediaitem.mediagenre,
                mediaauthor=mediaitem.mediaauthor,numberofcopies=mediaitem.numberofcopies});
            }
           
                return View(catmedia);
        }

    }
}
