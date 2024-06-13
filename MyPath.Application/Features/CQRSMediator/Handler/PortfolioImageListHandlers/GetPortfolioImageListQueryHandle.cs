using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.PortfolioImageListQueries;
using MyPath.Application.Features.CQRSMediator.Result.PortfolioImageListResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.PortfolioImageListHandlers
{
    public class GetPortfolioImageListQueryHandle : IRequestHandler<GetPortfolioImageListQuery, List<GetPortfolioImageListQueryResult>>
    {
        private readonly IRepository<PortfolioImageList> _repository;

        public GetPortfolioImageListQueryHandle(IRepository<PortfolioImageList> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetPortfolioImageListQueryResult>> Handle(GetPortfolioImageListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPortfolioImageListQueryResult
            {
                ImageUrl = x.ImageUrl,
                PortfolioDetailId = x.PortfolioDetailId,
                PortfolioImageListId= x.PortfolioImageListId,
            }).ToList();
        }
    }
}
