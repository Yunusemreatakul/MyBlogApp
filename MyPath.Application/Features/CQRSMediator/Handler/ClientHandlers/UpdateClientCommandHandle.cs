using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.ClientCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ClientHandlers
{
    public class UpdateClientCommandHandle : IRequestHandler<UpdateClientCommand>
    {
        private readonly IRepository<Client> _reposistory;

        public UpdateClientCommandHandle(IRepository<Client> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.ClientId);
            value.ClientId = request.ClientId;
            value.CompanyName = request.CompanyName;
            value.LogoUrl = request.LogoUrl;
            value.WebSiteUrl = request.WebSiteUrl;
            value.IsActive = request.IsActive;
            value.UserId = request.UserId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
