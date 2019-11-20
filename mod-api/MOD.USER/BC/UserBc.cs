using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.DATA;
using MOD.DATA.Model;
using MOD.LOG;

namespace MOD.USER.BC
{
    public class UserBc : IUserBc
    {
        IUnitOfWork UnitOfWork;
        ILog logger;
        public UserBc(IUnitOfWork _UnitOfWork, ILog _logger)
        {
            UnitOfWork = _UnitOfWork;
            logger = _logger;
        }

        public User GetUserById(int userId)
        {
            logger.Information("Execute Get user by id..");
            return UnitOfWork.User.GetUserById(userId);
        }
    }
}
