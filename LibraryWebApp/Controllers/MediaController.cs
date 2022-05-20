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
    public class MediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMedia(Catalogue model)
        {
            BSUsers bsmedia = new BSUsers();
            DTOMedia media = new DTOMedia();
            media.medianame = model.medianame;
            media.mediatype=model.mediatype;
            media.mediaauthor=model.mediaauthor;
            media.numberofcopies=model.numberofcopies;
            media.mediagenre=model.mediagenre;
            bsmedia.AddMedia(media);
            ModelState.Clear();
            return View();
          

        }
    }
}
