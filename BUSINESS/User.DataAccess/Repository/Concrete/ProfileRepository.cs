using User.Core.Entities;
using User.DataAccess.Repository.Abstract;

namespace User.DataAccess.Repository.Concrete;

public class ProfileRepository : GenericRepository<Profile>, IProfileRepository
{
    public ProfileRepository(Context context) : base(context)
    {
    }
}