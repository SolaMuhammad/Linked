using BLL;
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
            //Amal
            List<Experience> experiences = new List<Experience>();
            var explist = BLL.ExperienceManager.GetAllExperience((Guid)Membership
                .GetUser().ProviderUserKey).ToList();
            foreach (User_Com_Experience item in explist)
            {

                Experience experience = (Experience)Page.LoadControl("Controllers/Experience.ascx");
                experiences.Add(experience);
                experience.DataBind();
                this.Controls.Add(experience);
                experience.ComName.InnerHtml = item.Company.Name ;
                experience.FromDate.InnerHtml = item.from.ToString();
                experience.ToDate.InnerHtml = item.to.ToString();
                experience.JobTitle.InnerHtml = item.title;
            }
            
            AppManager UOW = new AppManager();
            var edlist = EducationManager.GetAllByUserId((Guid)Membership
                .GetUser().ProviderUserKey).ToList();
            foreach (User_Education item in edlist)
            {

                education education = (education)Page.LoadControl("Controllers/education.ascx");
                
                this.Controls.Add(education);
                education.eduName.InnerHtml = UOW.Education_Organization
                    .GetById(item.FK_EduId)[0].Name;
                education.dateFrom.InnerHtml = item.Date_From.ToString();
                education.dateTo.InnerHtml = item.Date_To.ToString();
                education.grade.InnerHtml = item.Grade.ToString();
            }
            
        }
    }
}