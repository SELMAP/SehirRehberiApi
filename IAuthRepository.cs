﻿using SehirRehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Data
{
   public interface IAuthRepository
    {
        Task<User> Register(User user, string Password);
        Task<User> Login(string userName, string password);
        Task<bool> UserExists(string UserName);
        object GetSection(string v);
    }
}
