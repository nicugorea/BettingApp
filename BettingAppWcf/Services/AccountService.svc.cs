using BettingAppWcf.Models;
using System.Linq;

namespace BettingAppWcf.Services
{
    public class AccountService : IAccountService
    {
        public User GetUserByUsername(string username)
        {
            using (var database = new BettingAppDBEntities())
            {
                var user = database.Users.FirstOrDefault(u => u.Username == username);
                return user;
            }
        }


        public bool RegisterResult(User user)
        {
            using (var database = new BettingAppDBEntities())
            {
                var testUser = GetUserByUsername(user.Username);
                if (testUser != null)
                    return false;

                database.Users.Add(user);
                database.SaveChanges();
                return true;
            }
        }
    }
}
