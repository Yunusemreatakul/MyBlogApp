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
    public class UpdateExperienceCommandHandle : IRequestHandler<UpdateExperienceCommand>
    {
        private readonly IRepository<Experience> _reposistory;

        public UpdateExperienceCommandHandle(IRepository<Experience> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateExperienceCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.ExperienceId);
            value.ExperienceId = request.ExperienceId;
            value.authority = request.authority;
            value.StartDate = request.StartDate;
            value.FinishDate = request.FinishDate;
            value.Description = request.Description;
            value.UserId = request.UserId;
            value.JobDefinition= request.JobDefinition;
            await _reposistory.UpdateAsync(value);
        }
    }
}
