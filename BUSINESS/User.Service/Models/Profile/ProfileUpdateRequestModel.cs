namespace User.Service.Models.Profile;

public class ProfileUpdateRequestModel
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}