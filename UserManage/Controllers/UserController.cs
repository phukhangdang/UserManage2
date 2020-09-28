using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManage.Database.Entities;
using UserManage.Services.UserService;

namespace Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.Gets();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetByID(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User model)
        {
            _userService.Create(model);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public void Put([FromBody] User model)
        {
            _userService.Update(model);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteByID(id);
        }
    }
}
