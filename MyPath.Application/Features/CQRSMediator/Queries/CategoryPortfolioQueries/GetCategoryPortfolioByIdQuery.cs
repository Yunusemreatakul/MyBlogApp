using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.CategoryPortfolioResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.CategoryPortfolioQueries
{
    public class GetCategoryPortfolioByIdQuery:IRequest<GetCategoryPortfolioByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCategoryPortfolioByIdQuery(int id)
        {
            Id = id;
        }
    }
}
