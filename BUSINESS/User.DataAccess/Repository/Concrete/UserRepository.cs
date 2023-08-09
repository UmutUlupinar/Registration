using User.DataAccess.Repository.Abstract;

namespace User.DataAccess.Repository.Concrete;

public class UserRepository : GenericRepository<Core.Entities.User>, IUserRepository
{
    public UserRepository(Context context) : base(context)
    {
    }
}