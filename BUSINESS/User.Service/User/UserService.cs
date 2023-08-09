using User.Core.Enums;
using User.DataAccess.Repository.Abstract;
using User.Service.Models.User;

namespace User.Service.User;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// this method provides to add new User as passive by register process 
    /// </summary>
    /// <param name="requestModel"></param>
    /// <returns></returns>
    public Task Register(UserRegisterRequestModel requestModel)
    {
        var user = new Core.Entities.User()
        {
            UserName = requestModel.UserName,
            Mail = requestModel.Mail,
            Password = requestModel.Password,
            CreatedDate = DateTime.Now,
            UpdatedTime = DateTime.Now,
            Status = Status.Passive
        };
        return _userRepository.AddAsync(user);
    }

    /// <summary>
    /// this method provides to activate user status by user mail
    /// </summary>
    /// <param name="mail"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Task ActivateAccount(string mail)
    {
        var user = _userRepository.FirstOrDefaultAsync(u => u.Mail == mail).Result;
        user.Status = Status.Active;
        user.UpdatedTime = DateTime.Now;
        try
        {
            _userRepository.Update(user);
            return Task.CompletedTask;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public Task<UserLoginResponseModel> Login(UserLoginRequestModel requestModel)
    {
        throw new NotImplementedException();
    }
}