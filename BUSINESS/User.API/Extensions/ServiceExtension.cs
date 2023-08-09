using User.Service.Profile;
using User.Service.User;

namespace User.API.Extensions;

public static class ServiceExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService,UserService>();
        services.AddScoped<IProfileService, ProfileService>();
    }
}