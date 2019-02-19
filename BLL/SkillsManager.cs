
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class SkillsManager
    {

        public static void AddSkill(Guid userId, int skillId)
        {
            User_Skill userSkill = new User_Skill();
            userSkill.FK_UserId = userId;
            userSkill.FK_SkillId = skillId;
            AppManager.linkedInContext.User_Skill.Add(userSkill);
            AppManager.linkedInContext.SaveChanges();
        }
        public static void deleteSkill(Guid userId, int skillId)
        {
            User_Skill userSkill = new User_Skill();
            userSkill.FK_UserId = userId;
            userSkill.FK_SkillId = skillId;
            AppManager.linkedInContext.User_Skill.Remove(userSkill);
            AppManager.linkedInContext.SaveChanges();
        }

        /***
         * Load all the skills for the profile page
         * */
        public static List<Skill> GetAllByUserId(Guid userId)
        {
            List<int> skillIds = AppManager.linkedInContext.User_Skill
                .Where(e => e.FK_UserId == userId).Select(s=>s.FK_SkillId).ToList();
            return AppManager.linkedInContext.Skills
                .Where(p => skillIds.Any(c => c == p.Id)).ToList();
        }
    }
}
