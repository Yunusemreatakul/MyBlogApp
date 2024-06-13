using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.EducationCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.EducationHandlers
{
    public class RemoveEducationCommandHandle : IRequestHandler<RemoveEducationCommand>
    {
        private readonly IRepository<Education> _repository;

        public RemoveEducationCommandHandle(IRepository<Education> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveEducationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
