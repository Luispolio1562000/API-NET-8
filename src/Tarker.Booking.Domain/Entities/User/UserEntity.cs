﻿namespace Tarker.Booking.Domain.Entities.User;

public class UserEntity
{
    public int userId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}