using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class userActions
    {
       public static void uploadImages(int userId, string filePath)
        {
            User_Details ud = new User_Details();
            ud.Id = userId;
            ud.Image = filePath;
            AppManager.linkedInContext.User_Details.Add(ud);
            //AppManager.linkedInContext.User_Details
            //    .Where(e=>e.Id == userId).ToList()
            //    .ForEach(i=>i.Image = filePath);
        }

        public static string viewImage(int userId)
        {
            string path = "";
            return path;
        }
    }
}
