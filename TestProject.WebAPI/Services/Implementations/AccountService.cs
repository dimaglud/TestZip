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
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AccountService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<AccountModel>> GetAll()
        {
            var list = await _context.Accounts.ToListAsync();

            return _mapper.Map<List<AccountModel>>(list);
        }

        public async Task<Guid> Add(AccountModel model)
        {
            var entity = _mapper.Map<Account>(model);
            entity.Id = Guid.NewGuid();
            entity.CreatedDate = DateTime.UtcNow;

            await _context.Accounts.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }
    }
}
