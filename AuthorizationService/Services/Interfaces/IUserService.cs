﻿using AuthorizationService.Models;

namespace AuthorizationService.Services.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        void CreateUser(string username, string password);
    }
}
