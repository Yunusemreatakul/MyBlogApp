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
    public class UpdateRoleCommandHandle : IRequestHandler<UpdateRoleCommand>
    {
        private readonly IRepository<Role> _reposistory;

        public UpdateRoleCommandHandle(IRepository<Role> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.RoleId);
            value.RoleName = request.RoleName;
            value.RoleId = request.RoleId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
