
using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class UserSkillsManager : Repository<User_Skill, LinkedInContext>
    {
        public UserSkillsManager(LinkedInContext context) : base(context)
        {
        }

        //public static void AddSkill(Guid userId, int skillId)
        //{
        //    User_Skill userSkill = new User_Skill();
        //    userSkill.FK_UserId = userId;
        //    userSkill.FK_SkillId = skillId;
        //    AppManager.linkedInContext.User_Skill.Add(userSkill);
        //    AppManager.linkedInContext.SaveChanges();
        //}
        //public static void deleteSkill(Guid userId, int skillId)
        //{
        //    User_Skill userSkill = new User_Skill();
        //    userSkill.FK_UserId = userId;
        //    userSkill.FK_SkillId = skillId;
        //    AppManager.linkedInContext.User_Skill.Remove(userSkill);
        //    AppManager.linkedInContext.SaveChanges();
        //}

        /***
         * Load all the skills for the profile page
         * */
        public  List<int> GetAllByUserId(Guid userId)
        {
            return GetAll().
                Where(e => e.FK_UserId == userId).Select(s=>s.FK_SkillId).ToList();
           
        }
    }
}
