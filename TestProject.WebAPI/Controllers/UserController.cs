using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TestProject.WebAPI.Models;
using TestProject.WebAPI.Services;

namespace TestTask.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> Get()
        {
            var ret = await _userService.GetAll();
            return ret;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> Get(Guid id)
        {
            var ret = await _userService.GetById(id);
            return ret;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserModel user)
        {
            //TODO: move validation to services, throw exceptions and add action filter to translete them to error model
            if (!ModelState.IsValid)
                return new ObjectResult(new ResultModel { IsSuccess = false, ErrorCode = ErrorCodes.InvalidModel, ErrorMessage = "Model is invalid" });

            var ret = await _userService.Add(user);
            return new ObjectResult(ret);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody] UserModel user)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
