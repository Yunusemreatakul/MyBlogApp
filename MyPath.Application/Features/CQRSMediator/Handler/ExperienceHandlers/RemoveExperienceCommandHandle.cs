using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.ExperienceCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ExperienceHandlers
{
    public class RemoveExperienceCommandHandle : IRequestHandler<RemoveExperienceCommand>
    {
        private readonly IRepository<Experience> _repository;

        public RemoveExperienceCommandHandle(IRepository<Experience> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveExperienceCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
