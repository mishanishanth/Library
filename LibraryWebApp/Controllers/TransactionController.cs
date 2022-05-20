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
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Transaction()
        {
            BSUsers bsuser = new BSUsers();
            List<DTOTran> trans = new List<DTOTran>();
            List<transaction> tranmodel=new List<transaction>();
            string username = HttpContext.Session.GetString("User");
            string userrole = HttpContext.Session.GetString("userrole");
            if (userrole == "Administrator" || userrole == "Librarian")
                trans.AddRange(bsuser.viewtransaction(0));
            else
            {
                int userid = Convert.ToInt32(HttpContext.Session.GetInt32("userid"));
                trans.AddRange(bsuser.viewtransaction(userid));
            }
            foreach (var tran in trans)
            {
                tranmodel.Add(new transaction                    { 
                    transactionid = tran.transactionid,
                    username = tran.username,
                    transactiondate = tran.transactiondate,
                    transactiontype = tran.transactiontype,
                    userid = tran.userid,
                    transactionstatus = tran.transactionstatus,
                    medianame = tran.medianame,
                    mediaqty = tran.mediaqty
            });
            }
            return View(tranmodel);

        }
    }
}
