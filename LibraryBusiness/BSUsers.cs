using LbAssgLibrary;
using LibraryBusinessDB;
using System.Collections.Generic;

namespace LibraryBusiness
{
    public class BSUsers
    {

        DBEngine engine = new DBEngine();
        

        public void Register(DTOUser userdata)
        {
           engine.insertuserdata(userdata);
        }

        public List<DTOMedia> search(string medianame)

        {
            List<DTOMedia> mlist = new List<DTOMedia>();
            if (string.IsNullOrEmpty(medianame))
            {
                engine.viewmediadata(mlist, "");
            }
            else
            {
                engine.viewmediadata(mlist, medianame);
            }
            return mlist;
        }
        public void AddMedia(DTOMedia medialist)
        {
            engine.mediainsert(medialist);
        }
        public DTOMedia ViewMedia(int mediaid)
        {
            return engine.viewmediadata(mediaid);
            
        }
        public void checkout(string media)
        {
            

        }
        public List<DTORole> Viewrole()
        {
            List<DTORole> roles = new List<DTORole>();
            engine.viewroledata(roles);
            return roles;
        }
        public DTOUser ViewUser(string username,string psswd)
        {
            DTOUser userlogin=new DTOUser();
            userlogin= engine.autheticateuser(username,psswd);
            return userlogin;
        }
        public int EditUser(DTOUser u)
        {            
            return engine.EditUser(u);
        }

        public List<DTOUser> ViewUserFull(string username)
        {
              return engine.viewuserdata(username);

        }
        public DTOUser viewUser(int userid)
        {
            DTOUser userdata=new DTOUser();
            return engine.viewuserdata(userid);
        }
        public List<DTOUser> viewUser(string username)
        {
            DTOUser userdata = new DTOUser();
            return engine.viewuserdata(username);
        }

        public void inserttransaction(DTOTran tran)
        {
            engine.inserttransaction(tran); 
            
        }

        public List<DTOTran> viewtransaction(int userid)
        {
            return engine.viewtransaction(userid);
        }
    }

}
