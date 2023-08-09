﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using User.Core.Entities;

namespace User.DataAccess.EntityConfiguration;

public class ProfileEntityConfiguration : IEntityTypeConfiguration<Profile>
{ 
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.User).IsRequired();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.LastName).IsRequired();
        builder.ToTable("Profiles");
    }
}