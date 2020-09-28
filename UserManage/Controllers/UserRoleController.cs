using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database.Entities;
using UserManage.Services.UserRoleService;

namespace UserManage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : Controller
    {
        private IUserRoleService _userRoleService;
        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserRole> Get()
        {
            return _userRoleService.Gets();
        }
        
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserRole Get(int id)
        {
            return _userRoleService.GetByID(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserRole model)
        {
            _userRoleService.Create(model);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public void Put([FromBody] UserRole model)
        {
            _userRoleService.Update(model);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userRoleService.DeleteByID(id);
        }
        
    }
}
