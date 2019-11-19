using MOD.DATA.Model;
using MOD.DATA.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.DATA.Repository.Model
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MODContext Context)
            : base(Context)
        {
        }

    }
}
