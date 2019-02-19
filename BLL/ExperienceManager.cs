using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExperienceManager : Repository<User_Com_Experience, LinkedInContext>
    {
        public ExperienceManager(LinkedInContext context) : base(context)
        {
        }

        //public static void AddExperience(Guid userId, int companyId
        //    , string details)
        //{
        //    User_Com_Experience uce = new User_Com_Experience();
        //    uce.FK_UserId = userId;
        //    uce.FK_CompId = companyId;
        //    uce.Detials = details;
        //    AppManager.linkedInContext.User_Com_Experience.Add(uce);

        //}

        //public static List<User_Com_Experience> GetAllExperience(int userId)
        //{
        //    return AppManager.linkedInContext.User_Com_Experience.ToList();

        //}

    }
}
