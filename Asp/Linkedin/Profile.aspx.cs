using DAL;
using LinkedIn.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIn
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Experience> experiences = new List<Experience>();
            Experience experience = new Experience();
            
            var list = BLL.ExperienceManager.GetAllExperience((Guid)Membership
                .GetUser().ProviderUserKey).ToList();
            //this.AddedControl(experience, 0);

            //foreach (User_Com_Experience item in list)
            //{
            //    experience
            //    experiences.Add(item.Company.Name);
            // }
        }
    }
}