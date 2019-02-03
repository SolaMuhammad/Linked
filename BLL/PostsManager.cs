using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PostsManager
    {
        static LinkedInEntitiesContext linkedInContext = 
            new LinkedInEntitiesContext();
        public static List<Post> GetAll()
        {
            return linkedInContext.Posts.ToList();
        }
        public static List<Post> GetAllByDate()
        {
            return linkedInContext.Posts
                .OrderBy(p=>p.Date).ToList();
        }
        public static List<Post> GetAllByTop()
        {
            return linkedInContext.Posts
                .OrderBy(p => p.Num_Of_Comments).ToList();
        }
        public static List<Post> GetAllByUserId(int userId)
        {
            return linkedInContext.Posts
                .Where(e=>e.FK_CreatorId == userId).ToList();
        }
    }
}
