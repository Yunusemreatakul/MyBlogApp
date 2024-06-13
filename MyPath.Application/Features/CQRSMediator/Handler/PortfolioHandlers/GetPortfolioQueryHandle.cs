using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.PortfolioQueries;
using MyPath.Application.Features.CQRSMediator.Result.PortfolioResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.PortfolioHandlers
{
    public class GetPortfolioQueryHandle : IRequestHandler<GetPortfolioQuery, List<GetPortfolioQueryResult>>
    {
        private readonly IRepository<Portfolio> _repository;

        public GetPortfolioQueryHandle(IRepository<Portfolio> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetPortfolioQueryResult>> Handle(GetPortfolioQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPortfolioQueryResult
            {
                CategoryPortfolioId = x.CategoryPortfolioId,
                ImageUrl = x.ImageUrl,
                PortfolioDetailId = x.PortfolioDetailId,
                PortfolioId = x.PortfolioId,
                Title   = x.Title,
                UserId = x.UserId,

            }).ToList();
        }
    }
}
