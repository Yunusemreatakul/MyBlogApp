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
    public class CreateClientCommandHandle : IRequestHandler<CreateClientCommand>
    {
        private readonly IRepository<Client> _Repository;

        public CreateClientCommandHandle(IRepository<Client> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new Client
            {
                CompanyName = request.CompanyName,
                IsActive = request.IsActive,
                LogoUrl = request.LogoUrl,
                UserId = request.UserId,
                WebSiteUrl = request.WebSiteUrl,

            });
        }
    }
}
