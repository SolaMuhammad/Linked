using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommentsManager : Repository<Comment, LinkedInContext>
    {

        public CommentsManager(LinkedInContext context) : base(context)
        {
        }

        //public static void AddComment(Guid userId, int postId, string commentText, DateTime date)
        //{
        //    Comment comment = new Comment();
        //    comment.FK_UserId =  userId;
        //    comment.FK_PostId = postId;
        //    comment.Comment_Text = commentText;
        //    AppManager.linkedInContext.Comments.Add(comment);
        //    AppManager.linkedInContext.SaveChanges();

        //}
        //public static void UpdateComment(Guid userId, int postId, string commentText, DateTime date)
        //{
        //    Comment comment = new Comment();
        //    comment.FK_UserId = userId;
        //    comment.FK_PostId = postId;
        //    comment.Comment_Text = commentText;
        //    AppManager.linkedInContext.Comments.Add(comment);
        //    AppManager.linkedInContext.SaveChanges();

        //}
        public static List<Comment> GetAllByPostId(int postId)
        {

            List<Comment> commList = AppManager.linkedInContext.Comments.Where(u => u.FK_PostId == postId).Select(l => l).ToList();
            return commList; ;
        }
        //public static void deleteComment(int commenttId)
        //{
        //    Comment commentToDelete = (Comment)AppManager.linkedInContext.Comments
        //        .Select(p => p).Where(p => p.Id == commenttId).FirstOrDefault();
        //    AppManager.linkedInContext.Comments.Remove(commentToDelete);
        //    AppManager.linkedInContext.SaveChanges();
        //}

    }

}
