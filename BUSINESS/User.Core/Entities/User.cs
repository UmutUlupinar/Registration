namespace User.Core.Entities;

public partial class User : BaseEntity
{
    public string UserName { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }
    
}

public partial class User
{
    public Profile Profile { get; set; }
}