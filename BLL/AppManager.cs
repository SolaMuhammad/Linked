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
        public static LinkedInContext linkedInContext =
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


    }
}
