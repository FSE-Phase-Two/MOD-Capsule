using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MOD.SECURITY.BC;

namespace MOD.SECURITY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILoginBC loginBc;
        IConfiguration _config;
        public LoginController(IConfiguration config, ILoginBC _loginBc)
        {
            _config = config;
            loginBc = _loginBc;
        }
        // GET: api/Login
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult response = Unauthorized();
            var isAuthenticate = loginBc.IsAuthenticateUser("rabi", "");

            if (isAuthenticate)
            {
                var tokenString = loginBc.GenerateJSONWebToken();
                response = Ok(new { token = tokenString });
            }

            return response;
            // return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            IActionResult response = Unauthorized();
            var isAuthenticate = loginBc.IsAuthenticateUser("rabi", "");

            if (isAuthenticate)
            {
                var tokenString = loginBc.GenerateJSONWebToken();
                response = Ok(new { token = tokenString });
            }

            return response;


        }

        // POST: api/Login
        [HttpPost]
        public IActionResult Post([FromBody] string userName,string password)
        {
            IActionResult response = Unauthorized();
            var isAuthenticate = loginBc.IsAuthenticateUser("rabi", "");

            if (isAuthenticate)
            {
                var tokenString = loginBc.GenerateJSONWebToken();
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        // PUT: api/Login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
