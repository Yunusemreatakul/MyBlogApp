using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.EducationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.EducationQueries
{
    public class GetEducationQuery:IRequest<List<GetEducationQueryResult>>
    {
    }
}
