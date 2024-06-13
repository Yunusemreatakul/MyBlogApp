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
    public class RemoveClientCommandHandle : IRequestHandler<RemoveClientCommand>
    {
        private readonly IRepository<Client> _repository;

        public RemoveClientCommandHandle(IRepository<Client> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveClientCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
