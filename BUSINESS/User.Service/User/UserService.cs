using User.Service.Models.User;

namespace User.Service.User;

public class UserService : IUserService
{
    public Task Register(UserRegisterRequestModel requestModel)
    {
        throw new NotImplementedException();
    }

    public Task ActivateAccount()
    {
        throw new NotImplementedException();
    }

    public Task<UserLoginResponseModel> Login(UserLoginRequestModel requestModel)
    {
        throw new NotImplementedException();
    }
}