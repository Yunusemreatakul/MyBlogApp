using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.EducationQueries;
using MyPath.Application.Features.CQRSMediator.Result.EducationResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.EducationHandlers
{
    public class GetEducationQueryHandle : IRequestHandler<GetEducationQuery, List<GetEducationQueryResult>>
    {
        private readonly IRepository<Education> _repository;

        public GetEducationQueryHandle(IRepository<Education> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetEducationQueryResult>> Handle(GetEducationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetEducationQueryResult
            {
                Address = x.Address,
                Description = x.Description,
                EducationId = x.EducationId,
                FinishDate = x.FinishDate,
                SchoolName = x.SchoolName,
                StartDate = x.StartDate,
                UserId=x.UserId,
            }).ToList();
        }
    }
}
