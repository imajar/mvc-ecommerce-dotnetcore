﻿using System.Collections.Generic;
using ECommerceDatabase.Database.Entities;

namespace ECommerceRepository.BusinessLogic
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        bool IsEmailInUse(string emailAddress);
        void DeleteUser(int userId);
        User GetUserById(int userId);
        bool UpdateUser(User user);
        List<User> GetLatestNewUsers(int numberOfUsers);
    }
}