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
    public class CreateSkillsCommandHandle : IRequestHandler<CreateSkillsCommand>
    {
        private readonly IRepository<Skils> _repository;

        public CreateSkillsCommandHandle(IRepository<Skils> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSkillsCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Skils
            {
                CreatingIsActive = request.CreatingIsActive,
                Description = request.Description,
                IconUrl = request.IconUrl,
                LongDescription = request.LongDescription,
                Rate = request.Rate,
                SkilIsActive = request.CreatingIsActive,
                SkilName = request.SkilName,
                UserId = request.UserId,
            });
        }
    }
}
