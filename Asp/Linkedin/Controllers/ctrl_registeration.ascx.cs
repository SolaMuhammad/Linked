using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.controls
{
    public partial class ctrl_registeration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  (CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Email") as TextBox).Visible = false;
            (CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Question") as TextBox).Visible = false;
            (CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Answer") as TextBox).Visible = false;

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            
        }

        protected void ContinueButton_Click(object sender, EventArgs e)
        {

            //AppManager userActions = new AppManager();
            //userActions.userDetails.Register(sender);
        }

        protected void CreateUserWizard1_CreatedUser1(object sender, EventArgs e)
        {
            var user = Membership.GetUser((sender as CreateUserWizard).UserName).ProviderUserKey;

            Guid userId = (Guid)user;
            AppManager userActions = new AppManager();
            User_Details user_Details = new User_Details();
            user_Details.Id = userId;
            userActions.userDetails.Add(user_Details);
        }
    }
}