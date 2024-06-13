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
    public class GetSkillsQueryHandle : IRequestHandler<GetSkillsQuery, List<GetSkillsQueryResult>>
    {
        private readonly IRepository<Skils> _repository;

        public GetSkillsQueryHandle(IRepository<Skils> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSkillsQueryResult>> Handle(GetSkillsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSkillsQueryResult
            {
                CreatingIsActive=x.CreatingIsActive,
                Description = x.Description,
                IconUrl = x.IconUrl,
                LongDescription = x.LongDescription,
                Rate = x.Rate,
                SkilIsActive = x.SkilIsActive,
                SkilName = x.SkilName,
                SkilsId = x.SkilsId,
                UserId=x.UserId,
            }).ToList();
        }
    }
}
