using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ShareManager
    {
        public static void SharePost(int userId, int postId
            , string comment)
        {
            Shared_Post post = new Shared_Post();
            post.post_id = postId;
            post.Sharing_UserId = userId;
            post.Comment = comment;
            AppManager.linkedInContext.Shared_Post.Add(post);
        }
        
    }
}
