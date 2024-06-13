using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.ContactResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.ContactQueries
{
    public class GetContactQuery:IRequest<List<GetContactQueryResult>>
    {
    }
}
