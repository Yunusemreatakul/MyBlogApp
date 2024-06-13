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
    public class GetEducationByIdQueryHandle : IRequestHandler<GetEducationByIdQuery, GetEducationByIdQueryResult>
    {
        private readonly IRepository<Education> _repository;

        public GetEducationByIdQueryHandle(IRepository<Education> repository)
        {
            _repository = repository;
        }
        public async Task<GetEducationByIdQueryResult> Handle(GetEducationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetEducationByIdQueryResult
            {
                Address = value.Address,
                Description = value.Description,
                EducationId = value.EducationId,
                FinishDate = value.FinishDate,
                SchoolName = value.SchoolName,
                StartDate = value.StartDate,
                UserId = value.UserId,


            };
        }
    }
}
