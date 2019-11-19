using MOD.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.USER.BC
{
    public interface IUserBc
    {
        User GetUserById(int userId);
    }
}
