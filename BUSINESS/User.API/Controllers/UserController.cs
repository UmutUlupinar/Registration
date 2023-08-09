using Microsoft.AspNetCore.Mvc;
using User.Service.Models.User;
using User.Service.User;

namespace User.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class UserController : Controller
{

    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// this action provides to register user as passive
    /// </summary>
    /// <param name="requestModel"></param>
    [HttpPost]
    public async Task Register(UserRegisterRequestModel requestModel)
        => await _userService.Register(requestModel);

    /// <summary>
    /// this action provides to activate user by changing user status to active
    /// </summary>
    [HttpPost]
    public async Task ActivateAccount(string mail)
        => await _userService.ActivateAccount(mail);

    /// <summary>
    /// this action provides to login by UserName-password or Mail-Password
    /// </summary>
    /// <param name="requestModel"></param>
    /// <returns></returns>
    [HttpGet]
    public async Task<UserLoginResponseModel> Login(UserLoginRequestModel requestModel)
        => await _userService.Login(requestModel);
}