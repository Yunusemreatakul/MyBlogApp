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
    public class GetExperienceQueryHandle : IRequestHandler<GetExperienceQuery, List<GetExperienceQueryResult>>
    {
        private readonly IRepository<Experience> _repository;

        public GetExperienceQueryHandle(IRepository<Experience> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetExperienceQueryResult>> Handle(GetExperienceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetExperienceQueryResult
            {
                authority=x.authority,
                Description=x.Description,
                ExperienceId=x.ExperienceId,
                FinishDate=x.FinishDate,
                JobDefinition   = x.JobDefinition,
                StartDate=x.StartDate,
                UserId=x.UserId,
            }).ToList();
        }
    }
}
