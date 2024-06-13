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
    public class GetPortfolioByIdQueryHandle : IRequestHandler<GetPortfolioByIdQuery, GetPortfolioByIdQueryResult>
    {
        private readonly IRepository<Portfolio> _repository;

        public GetPortfolioByIdQueryHandle(IRepository<Portfolio> repository)
        {
            _repository = repository;
        }
        public async Task<GetPortfolioByIdQueryResult> Handle(GetPortfolioByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetPortfolioByIdQueryResult
            {
                CategoryPortfolioId = value.CategoryPortfolioId,
                ImageUrl = value.ImageUrl,
                PortfolioDetailId = value.PortfolioDetailId,
                PortfolioId = value.PortfolioId,
                Title = value.Title,
                UserId = value.UserId,
            };
        }
    }
}
