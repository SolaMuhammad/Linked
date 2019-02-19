using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;

namespace Presentation
{
    public partial class Home : System.Web.UI.Page
    {
        AppManager app = new AppManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //User_Details ud = new User_Details();
                //ud.Id = (Guid)Membership.GetUser().ProviderUserKey;
                //app.userDetails.Add(ud);
                var x = app.Post.GetAll();
                posts.DataSource = app.Post.GetAll();
                posts.DataTextField = "Post_Content";
                posts.DataValueField = "id";
                posts.DataBind();
              
            }
        }

        protected void Post_Click(object sender, EventArgs e)
        {
            //PostsManager.AddPost(Convert.ToInt32(
            //    userId.Text), content.Text);
            Post po = new Post();
            var x = content.Text;
            po.Post_Content = content.Text;

            po.FK_CreatorId = (Guid)Membership.GetUser().ProviderUserKey;

            Post p = app.Post.Add(po);
        }

        protected void btn_SaveImage_Click(object sender, EventArgs e)
        {
            if(FileUpload1.PostedFile != null)
            {
                Stream uploaded = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(uploaded);
                byte[] bytes = br.ReadBytes((Int32)uploaded.Length);

                //Save the Byte Array as File.
                string filePath =  Path.GetFileName(FileUpload1.FileName);
                File.WriteAllBytes(Server.MapPath(filePath), bytes);

                //Display the Image File.
                Image1.ImageUrl = filePath;
                Image1.Visible = true;
                //UserActions.uploadImages(Guid.NewGuid(), filePath);

            }
        }

        protected void Update_Post_Click(object sender, EventArgs e)
        {
             //Post post = PostsManager.GetByPostId(1);
             //PostsManager.GetByPostId(Convert.ToInt32(txt_postId.Text));
             //PostsManager.
        }

        protected void btn_ViewPost_Click(object sender, EventArgs e)
        {
            Post post = PostsManager.GetByPostId(Convert
                .ToInt32(txt_postId.Text));
            txt_postId.Text = post.Post_Content;
        }

        protected void btn_DeletePost_Click(object sender, EventArgs e)
        {
            PostsManager.deletePost(Convert.ToInt32(txt_postId.Text));
        }
    }
}