using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;

namespace Presentation
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                posts.DataSource = PostsManager.GetAll();
                posts.DataTextField = "Post_Content";
                posts.DataValueField = "id";
                posts.DataBind();
            }
        }

        protected void Post_Click(object sender, EventArgs e)
        {
            PostsManager.AddPost(Convert.ToInt32(
                userId.Text), content.Text);
        }

        protected void btn_SaveImage_Click(object sender, EventArgs e)
        {
            if(FileUpload1.PostedFile != null)
            {
                /** string imgFile = Path.GetFileName(FileUpload1
                     .PostedFile.FileName);
                 string path = Server.MapPath("../DAL/Images" + imgFile);
                 FileUpload1.SaveAs(path);*/

                Stream uploaded = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(uploaded);
                byte[] bytes = br.ReadBytes((Int32)uploaded.Length);

                //Save the Byte Array as File.
                string filePath =  Path.GetFileName(FileUpload1.FileName);
                File.WriteAllBytes(Server.MapPath(filePath), bytes);

                //Display the Image File.
                Image1.ImageUrl = filePath;
                Image1.Visible = true;
                userActions.uploadImages(2, filePath);

            }
        }
    }
}