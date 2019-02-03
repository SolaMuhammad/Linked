using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}