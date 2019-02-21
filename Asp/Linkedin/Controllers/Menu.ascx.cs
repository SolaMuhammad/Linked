using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIn.Controllers
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
        public void Network_Click(object sender, EventArgs e)
        {
            Response.Redirect("network.aspx");
        }
        public void jobs_Click(object sender, EventArgs e)
        {
            Response.Redirect("jobs.aspx");
        }
        public void notification_Click(object sender, EventArgs e)
        {
            Response.Redirect("notifications.aspx");
        }
        public void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}
