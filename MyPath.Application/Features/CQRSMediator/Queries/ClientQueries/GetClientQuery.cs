using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.ClientResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.ClientQueries
{
    public class GetClientQuery:IRequest<List<GetClientQueryResult>>
    {
    }
}
