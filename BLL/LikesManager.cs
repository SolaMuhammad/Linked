using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LikesManager : Repository<Like, LinkedInContext>
    {
        public LikesManager(LinkedInContext context) : base(context)
        {
        }

        //public static void AddLikes(Guid userId, int postId)
        //{
        //    Like userlike = new Like();
        //    userlike.userId = userId;
        //    userlike.postId = postId;
        //    AppManager.linkedInContext.Likes.Add(userlike);
        //    AppManager.linkedInContext.SaveChanges();
        //}
        ////public static void deleteLikes(Guid userId, int postId)
        ////{
        ////    Like userlike = new Like();
        ////    userlike.userId = userId;
        ////    userlike.postId = postId;
        ////    AppManager.linkedInContext.Likes.Remove(userlike);
        ////    AppManager.linkedInContext.SaveChanges();
        ////}
        public static List<User_Details> GetAll()
        {
            List<Like> likelist = AppManager.linkedInContext.Likes.Select(l => l).ToList();
            List<User_Details> users = new List<User_Details>();
            foreach (var item in likelist)
            {
                List<User_Details> u = AppManager.linkedInContext.User_Details.Where(e => e.Id == item.userId).ToList();
                users.Add(u[0]);
            }
            return users;

        }

    }
}
