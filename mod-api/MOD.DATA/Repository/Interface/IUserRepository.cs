﻿using MOD.DATA.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.DATA.Repository.Interface
{
    public interface IUserRepository
    {
        User GetUserById(int userId);
    }
}
