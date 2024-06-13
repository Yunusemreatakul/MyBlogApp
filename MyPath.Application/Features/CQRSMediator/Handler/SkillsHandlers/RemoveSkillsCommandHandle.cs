using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.SkillsCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.SkillsHandlers
{
    public class RemoveSkillsCommandHandle : IRequestHandler<RemoveSkillsCommand>
    {
        private readonly IRepository<Skils> _repository;

        public RemoveSkillsCommandHandle(IRepository<Skils> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveSkillsCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
