﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Persistence.Configuration;

public class UserConfiguration
{
    public UserConfiguration(EntityTypeBuilder<UserEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.userId);
        entityBuilder.Property(x => x.FirstName).IsRequired();
        entityBuilder.Property(x => x.LastName).IsRequired();
        entityBuilder.Property(x => x.UserName).IsRequired();
        entityBuilder.Property(x => x.Password).IsRequired();


        entityBuilder.HasMany(x => x.Bookings)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);
    }
}