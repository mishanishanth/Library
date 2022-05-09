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
    }

}
