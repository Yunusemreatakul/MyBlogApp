using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.UserCommands;
using MyPath.Application.Features.CQRSMediator.Command.UserCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.UserHandlers
{
    public class CreateUserCommandHandle:IRequestHandler<CreateUserCommand>
    {
        private readonly IRepository<User> _Repository;

        public CreateUserCommandHandle(IRepository<User> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new User
            {
                Email = request.Email,
                LastName = request.LastName,
                Name = request.Name,
                Password = request.Password,
                ProfileId = request.ProfileId,  
                RoleId = request.RoleId,
                
            });
        }
    }
}
