using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.RoleCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.RoleHandlers
{
    public class RemoveRoleCommandHandle : IRequestHandler<RemoveRoleCommand>
    {
        private readonly IRepository<Role> _repository;

        public RemoveRoleCommandHandle(IRepository<Role> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveRoleCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
