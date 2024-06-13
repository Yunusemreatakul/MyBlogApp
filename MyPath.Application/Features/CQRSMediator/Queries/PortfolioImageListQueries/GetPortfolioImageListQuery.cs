using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.PortfolioImageListResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.PortfolioImageListQueries
{
    public class GetPortfolioImageListQuery:IRequest<List<GetPortfolioImageListQueryResult>>
    {
    }
}
