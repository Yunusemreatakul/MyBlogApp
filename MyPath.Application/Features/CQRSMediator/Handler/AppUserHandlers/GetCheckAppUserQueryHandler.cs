using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.AppUserQueries;
using MyPath.Application.Features.CQRSMediator.Result.AppUserResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.AppUserHandlers
{
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserResult>
    {
        private readonly IRepository<User> _UserRepository;
        private readonly IRepository<Role> _RoleRepository;

        public GetCheckAppUserQueryHandler(IRepository<User> userRepository, IRepository<Role> roleRepository)
        {
            _UserRepository = userRepository;
            _RoleRepository = roleRepository;
        }

        public async Task<GetCheckAppUserResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserResult();
            var user = await _UserRepository.GetByFilterAsync(x => x.Email == request.Email && x.Password == request.Password);
            if(user==null)
            {
                values.IsExist=false;
            }
            else
            {
                values.IsExist = true;
                values.Email=user.Email;
                values.Role = (await _RoleRepository.GetByFilterAsync(x => x.RoleId == user.RoleId))?.RoleName;
                values.UserId = user.UserId;
             
            }
            return values;
        }
    }
}
