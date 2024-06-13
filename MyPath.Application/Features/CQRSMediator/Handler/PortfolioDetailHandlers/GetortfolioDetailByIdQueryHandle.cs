using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.PortfolioDetailQueries;
using MyPath.Application.Features.CQRSMediator.Result.PortfolioDetailResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.PortfolioDetailHandlers
{
    public class GetortfolioDetailByIdQueryHandle : IRequestHandler<GetPortfolioDetailByIdQuery, GetPortfolioDetailByIdQueryResult>
    {
        private readonly IRepository<PortfolioDetail> _repository;

        public GetortfolioDetailByIdQueryHandle(IRepository<PortfolioDetail> repository)
        {
            _repository = repository;
        }
        public async Task<GetPortfolioDetailByIdQueryResult> Handle(GetPortfolioDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetPortfolioDetailByIdQueryResult
            {
                DateReceived = value.DateReceived,
                PortfolioDetailId = value.PortfolioDetailId,
                PortfolioId = value.PortfolioId,
                Text = value.Text,
                Title = value.Title,
                TitleDesc = value.TitleDesc,
                TitleImageUrl = value.TitleImageUrl,
            };
        }
    }
}
