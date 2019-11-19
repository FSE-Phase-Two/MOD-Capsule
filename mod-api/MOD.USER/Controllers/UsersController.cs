using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.DATA.Model;
using MOD.LOG;
using MOD.USER.BC;

namespace MOD.USER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        IUserBc UserBc;
        ILog logger;
        public UsersController(IUserBc _UserBc, ILog _logger)
        {
            UserBc = _UserBc;
            logger = _logger;
        }
        // GET: api/User
        [HttpGet]
        // [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "user1", "user2", "user3" };
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            if (id != 0)
            {
                User user = UserBc.GetUserById(id);
                return Ok(user);
                // return Ok(new { userId = user.UserId, emailId = user.EmailId });
            }
            return NotFound();
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
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
