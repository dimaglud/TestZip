using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.WebAPI.Data;
using TestProject.WebAPI.Data.Entities;
using TestProject.WebAPI.Models;
using TestProject.WebAPI.Services;
using AutoMapper;

namespace TestProject.WebAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<UserModel>> GetAll()
        {
            var list = await _context.Users.ToListAsync();

            return _mapper.Map<List<UserModel>>(list);
        }

        public async Task<UserModel> GetById(Guid id)
        {
            var item = await _context.Users.FindAsync(id);

            return _mapper.Map<UserModel>(item);
        }

        public async Task<Guid> Add(UserModel model)
        {
            var entity = _mapper.Map<User>(model);
            entity.Id = Guid.NewGuid();

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }
    }
}
