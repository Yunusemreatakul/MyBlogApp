using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.RoleResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.RoleQueries
{
    public class GetRoleQuery:IRequest<List<GetRoleQueryResult>>
    {
    }
}
