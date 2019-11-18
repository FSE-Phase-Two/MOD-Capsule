using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MOD.SECURITY.BC
{
    public class LoginBC : ILoginBC
    {
        private IConfiguration _config;
        public LoginBC(IConfiguration config)
        {
            _config = config;
        }
        public bool IsAuthenticateUser(string userName, string password)
        {
            bool isValid = false;
            if (userName == "rabi")
                isValid = true;
            return isValid;

        }

        public string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                         new Claim(JwtRegisteredClaimNames.Sub, ""),
                         new Claim(JwtRegisteredClaimNames.Email, ""),
                         new Claim("DateOfJoing", DateTime.Now.ToShortDateString()),
                         new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                 _config["Jwt:Issuer"],
                 claims,
                 expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
