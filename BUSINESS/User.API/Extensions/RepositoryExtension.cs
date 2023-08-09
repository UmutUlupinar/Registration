using User.DataAccess.Repository.Abstract;
using User.DataAccess.Repository.Concrete;

namespace User.API.Extensions;

public static class RepositoryExtension
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IUserRepository),typeof(UserRepository));
        services.AddScoped(typeof(IProfileRepository),typeof(ProfileRepository));
    }
}