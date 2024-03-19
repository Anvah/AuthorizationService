using AuthorizationService.Services;
using AuthorizationService.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AuthorizationService
{
    public static class ConfigureServices
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IUserService, UserService>();
            services.AddTransient<IAuthService, AuthService>();

            return services;
            
        }      
    }
}
