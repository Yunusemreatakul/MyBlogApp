using MediatR;
using MyPath.Application.Enums;
using MyPath.Application.Features.CQRSMediator.Command.AppUserCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.AppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {
        private readonly IRepository<User> _repsoitroy;

        public CreateAppUserCommandHandler(IRepository<User> repsoitroy)
        {
            _repsoitroy = repsoitroy;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await _repsoitroy.CreateAsync(new User
            {
                Password = request.Password,
                Email = request.Email,
                LastName = request.LastName,
                Name = request.Name,
                RoleId = (int)RolesType.Member
            });
        }
    }
}
