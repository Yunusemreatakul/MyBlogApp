using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.ProfileCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ProfileHandlers
{
    public class RemoveProfileCommandHandle : IRequestHandler<RemoveProfileCommand>
    {
        private readonly IRepository<Profile> _repository;

        public RemoveProfileCommandHandle(IRepository<Profile> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProfileCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
