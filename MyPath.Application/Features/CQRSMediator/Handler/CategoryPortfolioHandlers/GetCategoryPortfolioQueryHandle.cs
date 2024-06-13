using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.CategoryPortfolioQueries;
using MyPath.Application.Features.CQRSMediator.Result.CategoryPortfolioResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.CategoryPortfolioHandlers
{
    public class GetCategoryPortfolioQueryHandle : IRequestHandler<GetCategoryPortfolioQuery, List<GetCategoryPortfolioQueryResult>>
    {
        private readonly IRepository<CategoryPortfolio> _repository;

        public GetCategoryPortfolioQueryHandle(IRepository<CategoryPortfolio> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCategoryPortfolioQueryResult>> Handle(GetCategoryPortfolioQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryPortfolioQueryResult
            {
                CategoryName = x.CategoryName,
                CategoryPortfolioId = x.CategoryPortfolioId,
                UserId=x.UserId,
            }).ToList();
        }
    }
}
