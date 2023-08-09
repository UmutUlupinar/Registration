using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using User.Core.Entities;

namespace User.DataAccess.EntityConfiguration;

public class UserEntityConfiguration: IEntityTypeConfiguration<Core.Entities.User>
{
    public void Configure(EntityTypeBuilder<Core.Entities.User> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(u => u.UserName).IsRequired();
        builder.Property(s => s.Password).IsRequired();
        builder.ToTable("Users");
        
        builder.HasOne(x => x.Profile)
            .WithOne(x => x.User)
            .HasForeignKey<Profile>(x => x.UserId);
    }
}