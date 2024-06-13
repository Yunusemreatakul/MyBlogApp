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
    public class RemoveUserCommandHandle : IRequestHandler<RemoveUserCommand>
    {
        private readonly IRepository<User> _repository;

        public RemoveUserCommandHandle(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
