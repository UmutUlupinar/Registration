using User.Service.Models.User;

namespace User.Service.User;

public interface IUserService
{
    Task Register(UserRegisterRequestModel requestModel);
    Task ActivateAccount(string mail);
    Task<UserLoginResponseModel> Login(UserLoginRequestModel requestModel);
}