using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.SkillsQueries;
using MyPath.Application.Features.CQRSMediator.Result.SkillsResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.SkillsHandlers
{
    public class GetSkillsByIdQueryHandle : IRequestHandler<GetSkillsByIdQuery, GetSkillsByIdQueryResult>
    {
        private readonly IRepository<Skils> _repository;

        public GetSkillsByIdQueryHandle(IRepository<Skils> repository)
        {
            _repository = repository;
        }
        public async Task<GetSkillsByIdQueryResult> Handle(GetSkillsByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetSkillsByIdQueryResult
            {
                CreatingIsActive = value.CreatingIsActive,
                Description = value.Description,
                IconUrl = value.IconUrl,
                LongDescription = value.LongDescription,
                Rate = value.Rate,
                SkilIsActive = value.SkilIsActive,
                SkilName = value.SkilName,
                SkilsId = value.SkilsId,
                UserId = value.UserId,
            };
        }
    }
}
