using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string userName, string password)
        {
            var users = new List<User>
            {
                new () { Id = 1, UserName = "joker", Password = "joker", Role = "manager" },
                new () { Id = 2, UserName = "robin", Password = "robin", Role = "employee" }
            };
            return users.FirstOrDefault(x => 
                   string.Equals(x.UserName, userName, StringComparison.CurrentCultureIgnoreCase)
                   && string.Equals(x.Password, password, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
