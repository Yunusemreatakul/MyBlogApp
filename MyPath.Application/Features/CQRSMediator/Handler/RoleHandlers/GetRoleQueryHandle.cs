using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.RoleQueries;
using MyPath.Application.Features.CQRSMediator.Result.RoleResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.RoleHandlers
{
    public class GetRoleQueryHandle : IRequestHandler<GetRoleQuery, List<GetRoleQueryResult>>
    {
        private readonly IRepository<Role> _repository;

        public GetRoleQueryHandle(IRepository<Role> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRoleQueryResult>> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetRoleQueryResult
            {
                RoleId = x.RoleId,
                RoleName = x.RoleName,
            }).ToList();
        }
    }
}
