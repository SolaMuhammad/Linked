using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SkillsManager : Repository<Skill, LinkedInContext>
    {
        public SkillsManager(LinkedInContext context) : base(context)
        {

        }
        public List<Skill> GetAllByUserId(List<int> skillIds)
        {
            return GetAll()
                .Where(p => skillIds.Any(c => c == p.Id)).ToList();
        }

    }
}
