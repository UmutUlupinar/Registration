namespace User.Service.Models.User;

public class UserLoginRequestModel
{
    public string UserNameOrMail { get; set; }
    public string Password { get; set; }
}