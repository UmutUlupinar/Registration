namespace User.Core.Entities;

public partial class Profile
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public Guid UserId { get; set; }
    
}

public partial class Profile
{
    public User User { get; set; }
}