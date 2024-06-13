using MediatR;
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
    public class UpdateUserCommandHandle : IRequestHandler<UpdateUserCommand>
    {
        private readonly IRepository<User> _reposistory;

        public UpdateUserCommandHandle(IRepository<User> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.UserId);
            value.RoleId = request.RoleId;
            value.UserId = request.UserId;
            value.LastName = request.LastName;
            value.Name = request.Name;
            value.Email = request.Email;
            value.Password = request.Password;
            value.ProfileId = request.ProfileId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
