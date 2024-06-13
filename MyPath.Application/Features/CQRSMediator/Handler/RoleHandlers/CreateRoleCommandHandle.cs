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
    public class CreateRoleCommandHandle : IRequestHandler<CreateRoleCommand>
    {
        private readonly IRepository<Role> _Repository;

        public CreateRoleCommandHandle(IRepository<Role> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new Role
            {
               RoleName = request.RoleName,
               

            });
        }
    }
}
