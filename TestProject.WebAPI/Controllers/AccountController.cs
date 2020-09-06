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
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountModel>>> Get()
        { 
            var ret = await _accountService.GetAll();
            return ret;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccountModel>> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AccountModel account)
        {
            //TODO: move validation to services, throw exceptions and add action filter to translete them to error model
            if (!ModelState.IsValid)
                return new ObjectResult(new ResultModel { IsSuccess = false, ErrorCode = ErrorCodes.InvalidModel, ErrorMessage = "Model is invalid" });

            //TODO: check business logic


            var ret = await _accountService.Add(account);
            return new ObjectResult(ret);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] AccountModel account)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
