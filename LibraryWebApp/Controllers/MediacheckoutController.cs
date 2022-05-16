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
    public class MediacheckoutController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ViewResult Details(int mediaid)
        {
            BSUsers bsu = new BSUsers();
            DTOMedia media=new DTOMedia();
            Mediacheckout mcheck = new Mediacheckout();
            DTOTran tran = new DTOTran();
            media=bsu.ViewMedia(mediaid);
            mcheck.mediaid = media.mediaid;
            mcheck.medianame = media.medianame; 
            mcheck.numberofcopies = media.numberofcopies;
            mcheck.mediatype=media.mediatype;
            mcheck.mediaauthor=media.mediaauthor;
            mcheck.mediagenre=media.mediagenre;
            string username = HttpContext.Session.GetString("User");
            int userid = Convert.ToInt32(HttpContext.Session.GetInt32("userid"));
            tran.userid = userid;
            tran.mediaid=media.mediaid;
            tran.mediaqty = 1;
            tran.transactionstatus = "P";
            tran.transactiontype = "COUT";
            bsu.inserttransaction(tran);
            return View(mcheck);

        }
        public ViewResult Checkout()
        {
            BSUsers bsu = new BSUsers();
            List<DTOMedia> media = new List<DTOMedia>();
            List<Mediacheckout>catmedia = new List<Mediacheckout>();
            media.AddRange(bsu.search(""));
            foreach (DTOMedia mediaitem in media)
            {
                catmedia.Add(new Mediacheckout
                {
                    mediaid = mediaitem.mediaid,
                    medianame = mediaitem.medianame,
                    numberofcopies = mediaitem.numberofcopies,
                    mediacheck = false
                });
            }
           return View(catmedia);
        }

        [HttpPost]
        public IActionResult Checkout(List<Mediacheckout> media)
        {
               // return RedirectToAction("ChckSubmit", catmedia);
            return View();
        }

    }
}
