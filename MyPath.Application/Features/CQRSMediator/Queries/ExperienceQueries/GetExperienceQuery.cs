using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.ExperienceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.ExperienceQueries
{
    public class GetExperienceQuery:IRequest<List<GetExperienceQueryResult>>
    {
    }
}
