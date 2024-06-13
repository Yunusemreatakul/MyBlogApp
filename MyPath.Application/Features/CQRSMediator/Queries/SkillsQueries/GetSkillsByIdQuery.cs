using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.SkillsResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.SkillsQueries
{
    public class GetSkillsByIdQuery:IRequest<GetSkillsByIdQueryResult>
    {
        public int Id { get; set; }

        public GetSkillsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
