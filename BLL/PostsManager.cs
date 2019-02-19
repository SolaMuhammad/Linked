using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class PostsManager: Repository<Post, LinkedInContext>
    {
        public PostsManager(LinkedInContext context) : base(context)
        {
        }

        //public static List<Post> GetAll()
        //{
        //    return AppManager.linkedInContext.Posts.ToList();
        //}
        public static List<Post> GetAllByDate(Guid userId)
        {
            List<Guid> cons = AppManager.linkedInContext
                .Connection_Requeset.Where(c=>c.FK_UserId == userId)
                .Where(c => c.IsApproved == true)
                .Select(c=>c.FK_Connction_UserId).ToList();
            return AppManager.linkedInContext.Posts
                .Where(p=> cons.Any(c=>c == p.FK_CreatorId ))
                .OrderBy(p=>p.Date).ToList();
        }
        public static List<Post> GetAllByTop(Guid userId)
        {
            /***
             * Get Connections of the user who he has access to 
             * view his posts
             * */
            List<Guid> cons = AppManager.linkedInContext
                .Connection_Requeset.Where(c => c.FK_UserId == userId)
                .Where(c => c.IsApproved == true)
                .Select(c => c.FK_Connction_UserId).ToList();
            /***
             * Get the posts of people in cons
             * */
            return AppManager.linkedInContext.Posts
                .Where(p => cons.Any(c => c == p.FK_CreatorId))
                .OrderBy(p => p.Num_Of_Comments).ToList();
        }
        //public static void AddPost(Guid userId, string postContent)
        //{
        //    Post post = new Post();
        //    post.FK_CreatorId = userId;
        //    post.Post_Content = postContent;
        //    AppManager.linkedInContext.Posts.Add(post);
        //    AppManager.linkedInContext.SaveChanges();
        //}
        public static void deletePost(int postId)
        {
            Post postToDelete = AppManager.linkedInContext.Posts
                .Select(p => p).Where(p => p.Id == postId).FirstOrDefault();
            AppManager.linkedInContext.Posts.Remove(postToDelete);
            AppManager.linkedInContext.SaveChanges();
        }

        /***
         * Load all the posts for the profile page
         * */
        public static List<Post> GetAllByUserId(Guid userId)
        {
            return AppManager.linkedInContext.Posts
                .Where(e=>e.FK_CreatorId == userId).ToList();
        }
        public static Post GetByPostId(int postId)
        {
            return (Post)AppManager.linkedInContext.Posts
                .Where(e => e.Id == postId);
        }
    }
}
