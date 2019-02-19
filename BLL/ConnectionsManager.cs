using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConnectionsManager : Repository<Connection_Requeset, LinkedInContext>
    {
        public ConnectionsManager(LinkedInContext context) : base(context)
        {
        }
        public static void AddFriendRequest(Guid userId, Guid connectionId)
        {
            Connection_Requeset friend = new Connection_Requeset();
            friend.FK_UserId = userId;
            friend.FK_Connction_UserId = connectionId;
            friend.IsApproved = false;
            AppManager.linkedInContext.Connection_Requeset.Add(friend);
            AppManager.linkedInContext.SaveChanges();

        }
        public static void DeleteFriend(Guid userId, Guid connectionId)
        {
            Connection_Requeset friend = new Connection_Requeset();
            friend.FK_UserId = userId;
            friend.FK_Connction_UserId = connectionId;
            AppManager.linkedInContext.Connection_Requeset.Remove(friend);
            AppManager.linkedInContext.SaveChanges();
        }
        public static List<User_Details> GetAllFriend(Guid userId)
        {

            List<Connection_Requeset> connlist = AppManager.linkedInContext.Connection_Requeset.Where(u => u.IsApproved == true && u.FK_UserId == userId).Select(l => l).ToList();
            List<User_Details> users = new List<User_Details>();
            foreach (var item in connlist)
            {
                List<User_Details> u = AppManager.linkedInContext.User_Details.Where(e => e.Id == item.FK_Connction_UserId).ToList();
                users.Add(u[0]);
            }
            return users;

        }
        public static List<User_Details> GetAllFriendRequest(Guid userId)
        {

            List<Connection_Requeset> connlist = AppManager.linkedInContext.Connection_Requeset.Where(u => u.IsApproved == false && u.FK_UserId == userId).Select(l => l).ToList();
            List<User_Details> users = new List<User_Details>();
            foreach (var item in connlist)
            {
                List<User_Details> u = AppManager.linkedInContext.User_Details.Where(e => e.Id == item.FK_Connction_UserId).ToList();
                users.Add(u[0]);
            }
            return users;

        }
        public static void AcceptFriendRequest(Guid userId, Guid connectionId)
        {
            Connection_Requeset result = AppManager.linkedInContext.Connection_Requeset.SingleOrDefault(u => u.FK_UserId == userId && u.FK_Connction_UserId == connectionId);
            if (result != null)
            {
                result.IsApproved = true;
                AppManager.linkedInContext.SaveChanges();

            }
            Connection_Requeset friend = new Connection_Requeset();
            friend.FK_UserId = connectionId;
            friend.FK_Connction_UserId = userId;
            friend.IsApproved = true;
            AppManager.linkedInContext.Connection_Requeset.Add(friend);
            AppManager.linkedInContext.SaveChanges();
        }

    }
}
