using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EducationManager : Repository<User_Education, LinkedInContext>
    {
        public EducationManager(LinkedInContext context) : base(context)
        {
        }

        public static List<User_Education> GetAllByUserId(Guid userId)
        {
            return AppManager.linkedInContext.User_Education
                .Where(ed => ed.FK_UserId == userId).ToList();
        }
    }
}
