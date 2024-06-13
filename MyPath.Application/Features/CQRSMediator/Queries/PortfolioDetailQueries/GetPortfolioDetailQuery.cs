using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.PortfolioDetailResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.PortfolioDetailQueries
{
    public class GetPortfolioDetailQuery:IRequest<List<GetPortfolioDetailQueryResult>>
    {
    }
}
