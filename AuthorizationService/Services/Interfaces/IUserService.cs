using AuthorizationService.Models;

namespace AuthorizationService.Services.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        string CreateUser(string username, string password);
    }
}
