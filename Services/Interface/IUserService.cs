﻿using Clinic_Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_Web_Api.Services.Interface
{
    public interface IUserService
    {
        int CreateUser(User user);
        int Delete(int id);
        bool Update(User stafuserf);
        User Find(int id);
        List<User> Find(string term);
        (List<User> users, int totalPage, int totalUsers) FindAll(int page);
        string Login(string username, string password);
        User IsUserExist(string username);
        bool UpdateUserPassword(string username, string newPw);

    }
}
