using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.WebAPI.Models;

namespace TestProject.WebAPI.Services
{
    public interface IAccountService
    {
        Task<List<AccountModel>> GetAll();

        Task<Guid> Add(AccountModel model);
    }
}
