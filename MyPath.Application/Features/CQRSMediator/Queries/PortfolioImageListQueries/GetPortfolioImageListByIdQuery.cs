using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.PortfolioImageListResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.PortfolioImageListQueries
{
    public class GetPortfolioImageListByIdQuery:IRequest<GetPortfolioImageListByIdQueryResult>
    {
        public int Id { get; set; }

        public GetPortfolioImageListByIdQuery(int id)
        {
            Id = id;
        }
    }
}
