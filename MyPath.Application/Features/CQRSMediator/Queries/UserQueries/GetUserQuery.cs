using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.UserResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.UserQueries
{
    public class GetUserQuery: IRequest<List<GetUserQueryResult>>
    {

    }
}
