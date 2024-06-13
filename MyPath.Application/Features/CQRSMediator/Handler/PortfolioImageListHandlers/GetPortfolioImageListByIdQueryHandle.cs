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
    public class GetPortfolioImageListByIdQueryHandle : IRequestHandler<GetPortfolioImageListByIdQuery, GetPortfolioImageListByIdQueryResult>
    {
        private readonly IRepository<PortfolioImageList> _repository;

        public GetPortfolioImageListByIdQueryHandle(IRepository<PortfolioImageList> repository)
        {
            _repository = repository;
        }

        public async Task<GetPortfolioImageListByIdQueryResult> Handle(GetPortfolioImageListByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetPortfolioImageListByIdQueryResult
            {
                ImageUrl = value.ImageUrl,
                PortfolioDetailId = value.PortfolioDetailId,
                PortfolioImageListId = value.PortfolioImageListId,
            };
        }
    }
}
