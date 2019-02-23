using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /**
     * Unit Of Work
     * */
    public class AppManager
    {
        public   static LinkedInContext linkedInContext =
            new LinkedInContext();
        public PostsManager Post
        {
            get
            {
                return new PostsManager(linkedInContext);
            }
        }
        public ExperienceManager User_Com_Experience
        {
            get
            {
                return new ExperienceManager(linkedInContext);
            }
        }
        public UserActions userDetails
        {
            get
            {
                return new UserActions(linkedInContext);
            }
        }
        public EducationManager EducationManager
        {
            get
            {
                return new EducationManager(linkedInContext);
            }
        }

        public Education_OrganizationManager Education_Organization
        {
            get
            {
                return new Education_OrganizationManager(linkedInContext);
            }
        }


    }
}
