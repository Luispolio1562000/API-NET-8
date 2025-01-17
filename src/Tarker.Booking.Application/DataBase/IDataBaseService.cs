﻿using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Domain.Entities.Booking;
using Tarker.Booking.Domain.Entities.Customer;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Application.DataBase;

public interface IDataBaseService
{
    DbSet<UserEntity> User { get; set; }
    DbSet<CustomerEntity> Cutomer { get; set; }
    DbSet<BookingEntity> Booking { get; set; }
    Task<bool> SaveAsync();
}