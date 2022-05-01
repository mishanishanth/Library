using Microsoft.VisualStudio.TestTools.UnitTesting;
using LbAssgLibrary;
using LibraryDBConnectLibrary;
using System.Collections.Generic;
using System;
using System.IO;

namespace UnitLibraryTest
{
    [TestClass]
    public class UnitTestLibrary
    {

        public DTORole _role;
        public DTOUser _user;
        public DBConnect _dbc;
        public UnitTestLibrary()
        {
            _role= new DTORole();
            _user= new DTOUser();
            _dbc= new DBConnect();
        }

        [TestMethod]
        public void loginsuccesful()
        {
            List<DTOUser> _userlist = new List<DTOUser>();
            _userlist.Add(new DTOUser
            {
                firstname = "Misha",
                lastname = "Nishanth",
                emailid = "mmisha.nishanth@gmail.com",
                username = "mishamm",
                password = "Misha123##",
                role = "Patron",
                phoneno = "6176394898"
            });
            // Call
            bool login_status = false;
            login_status = _user.authenticate(_userlist, "mishamm", "Misha123##");
            //Assert
            Assert.AreEqual(true,login_status);
          
        }
        [TestMethod]
        public void loginUnsuccessful()
        {
            List<DTOUser> _userlist = new List<DTOUser>();
            _userlist.Add(new DTOUser
            {
                firstname = "Misha",
                lastname = "Nishanth",
                emailid = "mmisha.nishanth@gmail.com",
                username = "mishamm",
                password = "Misha123##",
                role = "Patron",
                phoneno = "617639486"
            });
            // Call
            bool login_status = true;
            login_status = _user.authenticate(_userlist, "mishamm", "Misha123");
            //Assert
            Assert.AreEqual(false, login_status);

        }
        [TestMethod]
        public void PrintUserName()
        {
            List<DTOUser> _userlist = new List<DTOUser>();
            _userlist.Add(new DTOUser
            {
                firstname = "Misha",
                lastname = "Nishanth",
                emailid = "mmisha.nishanth@gmail.com",
                username = "mishamm",
                password = "Misha123##",
                role = "Patron",
                phoneno = "23492342"
            });
            string username;
            username = _user.PrintUser(_userlist, "PUT");
            Assert.AreEqual("mishamm", username);

        }
              
        [TestMethod]
        public void _logout()
        {
            List<DTOUser> _userlist = new List<DTOUser>();
            _userlist.Add(new DTOUser
            {
                firstname = "Misha",
                lastname = "Nishanth",
                emailid = "mmisha.nishanth@gmail.com",
                username = "mishamm",
                password = "Misha123##",
                role = "Patron",
                phoneno = "39432342"
             });
            char logout = _user.logout(_userlist, "mishamm");
            Assert.AreEqual('O', logout);
        }
        [TestMethod]
        public void _dbauthenticate()
        {
            _user = _dbc.autheticateuser("mmisha", "Nish4632#");
            Assert.AreEqual(_user.username, "mmisha");
        }
        [TestMethod]
        public void _getroleid()
        {
            int roleid;
            roleid = _dbc.getroleid("Guest");
            Assert.AreEqual(roleid,1);
        }
        [TestMethod]
        public void _getmediaid()
        {
            int mediaid;
            mediaid = _dbc.getmediaid("Harry Potter");
            Assert.AreEqual(mediaid,1);
        }
        [TestMethod]
        public void _getcheckout()
        {
            int retval;
            retval = _dbc.tranupdate(12);
            Assert.AreEqual(retval,0,1);
        }
        [TestMethod]
        public void _deleteuser()
        {
            int returnval;
            returnval = _dbc.deletuserdata("mahimamm");
            Assert.AreEqual(returnval, 1, 0);
        }
        [TestMethod]
        public void _deleterole()
        {
            int returnval;
            returnval = _dbc.deleteroledata("Patron");
            Assert.AreEqual(returnval , 1, 0);
        }

    }
}
