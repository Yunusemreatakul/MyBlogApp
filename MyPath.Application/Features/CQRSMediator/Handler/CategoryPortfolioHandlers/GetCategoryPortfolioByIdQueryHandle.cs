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
    public class GetCategoryPortfolioByIdQueryHandle : IRequestHandler<GetCategoryPortfolioByIdQuery, GetCategoryPortfolioByIdQueryResult>
    {
        private readonly IRepository<CategoryPortfolio> _repository;

        public GetCategoryPortfolioByIdQueryHandle(IRepository<CategoryPortfolio> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryPortfolioByIdQueryResult> Handle(GetCategoryPortfolioByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetCategoryPortfolioByIdQueryResult
            {
                CategoryName = value.CategoryName,
                CategoryPortfolioId = value.CategoryPortfolioId,
                UserId = value.UserId,
            };
        }
    }
}
