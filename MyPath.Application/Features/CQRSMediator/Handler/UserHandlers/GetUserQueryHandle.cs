using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.UserQueries;
using MyPath.Application.Features.CQRSMediator.Result.UserResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.UserHandlers
{
    public class GetUserQueryHandle : IRequestHandler<GetUserQuery, List<GetUserQueryResult>>
    {
        private readonly IRepository<User> _repository;

        public GetUserQueryHandle(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetUserQueryResult>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetUserQueryResult
            {
                Email = x.Email,
                LastName = x.LastName,
                Name = x.Name,
                Password = x.Password,
                ProfileId   = x.ProfileId,
                RoleId = x.RoleId,
                UserId= x.UserId,
            }).ToList();
        }

    }
}
