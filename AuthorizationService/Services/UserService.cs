using AuthorizationService.Models;
using AuthorizationService.Services.Interfaces;

namespace AuthorizationService.Services
{
    public class UserService : IUserService
    {
        private static List<User> _users = new List<User>
        {
            new User { Id = 1, Username = "user1", Password = "password1", Roles = new List<string> { "Admin" } },
            new User { Id = 2, Username = "user2", Password = "password2", Roles = new List<string> { "User" } }
        };

        public User Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.Username == username && x.Password == password);
        }
        public void CreateUser(string username, string password)
        {
            _users.Add(new User { Id = _users.Count + 1, Username = username, Password = password, Roles = new List<string> { "User" } });
        }
    }
}
