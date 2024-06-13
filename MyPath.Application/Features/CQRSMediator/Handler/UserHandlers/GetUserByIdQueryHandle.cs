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
    public class GetUserByIdQueryHandle : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResult>
    {
        private readonly IRepository<User> _repository;

        public GetUserByIdQueryHandle(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<GetUserByIdQueryResult> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetUserByIdQueryResult
            {
                UserId = value.UserId,
                Email = value.Email,
                LastName = value.LastName,
                Name = value.Name,
                Password = value.Password,
                ProfileId = value.ProfileId,
                RoleId = value.RoleId,
            };
        }
    }
}
