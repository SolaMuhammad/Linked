using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Views
    {
        //public static void AddViews(Guid userId, Guid viewerUserId, DateTime Date)
        //{
        //    Profile_Views view = new Profile_Views();
        //    view.FK_UserId = userId;
        //    view.Viewer_UserId = viewerUserId;
        //    view.Date = Date;
        //    AppManager.linkedInContext.Profile_Views.Add(view);
        //    AppManager.linkedInContext.SaveChanges();
        //}
        //public static List<User_Details> GetAllViews(Guid userId)
        //{
        //    List<Profile_Views> profile = AppManager.linkedInContext.Profile_Views.Where(u => u.FK_UserId == userId).Select(l => l).ToList();
        //    List<User_Details> users = new List<User_Details>();
        //    foreach (var item in profile)
        //    {
        //        List<User_Details> u = AppManager.linkedInContext.User_Details.Where(e => e.Id == item.Viewer_UserId).ToList();
        //        users.Add(u[0]);
        //    }
        //    return users;

        //}

    }
}
