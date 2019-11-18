using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.SECURITY.BC
{
    public interface ILoginBC
    {
        bool IsAuthenticateUser(string userName, string password);
        string GenerateJSONWebToken();
    }
}
