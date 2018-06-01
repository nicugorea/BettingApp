using BettingAppWcf.Models;
using System.Linq;

namespace BettingAppWcf.Services
{
    public class AccountService : IAccountService
    {

        public User GetUserById(int id)
        {
            using (var database = new BettingAppDBEntities())
            {
                var user = database.Users.FirstOrDefault(u => u.ID_User == id);
                return user;
            }
        }

        public User GetUserByUsername(string username)
        {
            using (var database = new BettingAppDBEntities())
            {
                var user = database.Users.FirstOrDefault(u => u.Username == username);
                return user;
            }
        }

        public bool IsAdmin(int id)
        {
            return GetUserById(id).Role == "admin";
        }

        public bool IsUser(int id)
        {
            return GetUserById(id).Role == "user";
        }

        public bool LoginResult(string username, string password)
        {
            using (var database = new BettingAppDBEntities())
            {
                var user = database.Users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                    return false;
                var hashPass = password.GetHashCode().ToString();
                if (user.Password == hashPass)
                    return true;
                else return false;
            }
        }

        public bool RegisterResult(string username, string password)
        {
            using (var database = new BettingAppDBEntities())
            {
                var testUser = GetUserByUsername(username);
                if (testUser != null)
                    return false;

                var user = new User();
                user.Username = username;
                user.Password = password.GetHashCode().ToString();
                user.Role = "user";

                database.Users.Add(user);
                database.SaveChanges();
                return true;
            }
        }
    }
}
