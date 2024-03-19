using AuthorizationService.Models.RequestModels;

namespace AuthorizationService.Services.Interfaces
{
    public interface IAuthService
    {     
        string Authenticate(AuthRequestModel request);
    }
}
