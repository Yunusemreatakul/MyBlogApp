using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.ContactCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ContactHandlers
{
    public class RemoveContactCommandHandle : IRequestHandler<RemoveContactCommand>
    {
        private readonly IRepository<Contact> _repository;

        public RemoveContactCommandHandle(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
