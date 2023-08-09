using User.Core.Enums;

namespace User.Core.Entities;

public class BaseEntity
{
    public Guid Id{ get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedTime { get; set; }
    public Status Status { get; set; }
}