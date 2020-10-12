using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManage.Database.Entities;
using UserManage.Services.CreateService;
using UserManage.Services.UpdateService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateController : ControllerBase
    {
        private readonly ICreateService _createService;
        public CreateController(CreateService createService)
        {
            _createService = createService;
        }
        // POST api/<CreateController>
        [HttpPost]
        public void Post([FromBody] User user, [FromBody] UserRole userRole)
        {
            _createService.Create(user, userRole);
        }
    }
}
