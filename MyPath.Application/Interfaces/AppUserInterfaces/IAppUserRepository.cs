using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Interfaces.AppUserInterfaces
{
    public interface IAppUserRepository
    {
        Task<List<User>> GetByFilterAsync(Expression<Func<User, bool>> filter);
    }
}
