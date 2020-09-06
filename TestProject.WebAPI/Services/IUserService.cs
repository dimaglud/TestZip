using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.WebAPI.Models;

namespace TestProject.WebAPI.Services
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAll();

        Task<UserModel> GetById(Guid id);

        Task<Guid> Add(UserModel model);
    }
}
