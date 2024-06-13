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
    public class GetortfolioDetailQueryHandle : IRequestHandler<GetPortfolioDetailQuery, List<GetPortfolioDetailQueryResult>>
    {
        private readonly IRepository<PortfolioDetail> _repository;

        public GetortfolioDetailQueryHandle(IRepository<PortfolioDetail> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetPortfolioDetailQueryResult>> Handle(GetPortfolioDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPortfolioDetailQueryResult
            {
                PortfolioId=x.PortfolioId,
                DateReceived = x.DateReceived,
                PortfolioDetailId=x.PortfolioDetailId,
                Text = x.Text,
                Title = x.Title,
                TitleDesc = x.TitleDesc,
                TitleImageUrl=x.TitleImageUrl,
            }).ToList();
        }
    }
}
