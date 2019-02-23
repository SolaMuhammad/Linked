using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Education_OrganizationManager : Repository<Education_Organization, LinkedInContext>
    {
        public Education_OrganizationManager(LinkedInContext context) : base(context)
        {
        }
    }
}
