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
    public class CreateExperienceCommandHandle : IRequestHandler<CreateExperienceCommand>
    {
        private readonly IRepository<Experience> _Repository;

        public CreateExperienceCommandHandle(IRepository<Experience> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateExperienceCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new Experience
            {
                UserId = request.UserId,
                StartDate=request.StartDate,
                authority=request.authority,
                Description=request.Description,
                FinishDate=request.FinishDate,
                JobDefinition = request.JobDefinition,
                


            });
        }
    }
}
