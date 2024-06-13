using Microsoft.EntityFrameworkCore;
using MyPath.Application.Interfaces.AppUserInterfaces;
using MyPath.Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly MyPathContext _context;

        public AppUserRepository(MyPathContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetByFilterAsync(Expression<Func<User, bool>> filter)
        {
            var values = await _context.Users.Where(filter).ToListAsync();
            return values;
        }
    }
}
