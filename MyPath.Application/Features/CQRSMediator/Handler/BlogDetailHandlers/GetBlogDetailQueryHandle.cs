using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.BlogDetailQueries;
using MyPath.Application.Features.CQRSMediator.Result.BlogDetailResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.BlogDetailHandlers
{
    public class GetBlogDetailQueryHandle : IRequestHandler<GetBlogDetailQuery, List<GetBlogDetailQueryResult>>
    {
        private readonly IRepository<BlogDetail> _repository;

        public GetBlogDetailQueryHandle(IRepository<BlogDetail> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBlogDetailQueryResult>> Handle(GetBlogDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBlogDetailQueryResult
            {
                BlogCardId = x.BlogCardId,
                BlogDetailId = x.BlogDetailId,
                BlogTitle = x.BlogTitle,
                Contributed = x.Contributed,
                Description1 = x.Description1,
                Description2 = x.Description2,
                Description3 = x.Description3,
                Description4 = x.Description4,
                ImageUrl1 = x.ImageUrl1,
                ImageUrl2 = x.ImageUrl2,
                ImageUrl3 = x.ImageUrl3,
            }).ToList();
        }
    }
}
