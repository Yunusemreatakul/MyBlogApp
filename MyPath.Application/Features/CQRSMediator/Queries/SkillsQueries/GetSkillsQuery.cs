using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.SkillsResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.SkillsQueries
{
    public class GetSkillsQuery:IRequest<List<GetSkillsQueryResult>>
    {
    }
}
