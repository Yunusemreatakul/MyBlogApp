using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.ExperienceQueries;
using MyPath.Application.Features.CQRSMediator.Result.ExperienceResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ExperienceHandlers
{
    public class GetExperienceByIdQueryHandle : IRequestHandler<GetExperienceByIdQuery, GetExperienceByIdQueryResult>
    {
        private readonly IRepository<Experience> _repository;

        public GetExperienceByIdQueryHandle(IRepository<Experience> repository)
        {
            _repository = repository;
        }
        public async Task<GetExperienceByIdQueryResult> Handle(GetExperienceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetExperienceByIdQueryResult
            {
                authority = value.authority,
                Description = value.Description,
                ExperienceId = value.ExperienceId,
                FinishDate = value.FinishDate,
                JobDefinition = value.JobDefinition,
                StartDate = value.StartDate,
                UserId = value.UserId,
            };
        }
    }
}
