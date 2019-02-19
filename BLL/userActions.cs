﻿using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace BLL
{
    public class UserActions : Repository<User_Details, LinkedInContext>
    {
        public UserActions(LinkedInContext context) : base(context)
        {
        }

        public  void uploadImages(Guid userId, string filePath)
        {
            User_Details ud = new User_Details();
            ud.Id = userId;
            ud.Image = filePath;
            AppManager.linkedInContext.User_Details.Add(ud);
            
        }

        public  string uploadProfilePicture(int userId)
        {
            string path = "";
            return path;
        }
        //public  User_Details Login()
        //{
        //    //var userName = Membership.GetUser().UserName;
        //    //if(.User_Details.Any(u=>u.Id == ))
        //    //return ud;
        //}
        public  User_Details Register()
        {
            var user = Membership.GetUser();
            Guid userId = (Guid)user.ProviderUserKey;
            User_Details ud = new User_Details();
            ud.Id = userId;
            return ud;
        }
    }
}
