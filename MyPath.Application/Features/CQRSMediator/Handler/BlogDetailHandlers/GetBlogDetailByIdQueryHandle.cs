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
    public class GetBlogDetailByIdQueryHandle : IRequestHandler<GetBlogDetailByIdQuery, GetBlogDetailByIdQueryResult>
    {
        private readonly IRepository<BlogDetail> _repository;

        public GetBlogDetailByIdQueryHandle(IRepository<BlogDetail> repository)
        {
            _repository = repository;
        }
        public async Task<GetBlogDetailByIdQueryResult> Handle(GetBlogDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetBlogDetailByIdQueryResult
            {
                BlogCardId = value.BlogCardId,
                BlogDetailId = value.BlogDetailId,
                BlogTitle = value.BlogTitle,
                Contributed = value.Contributed,
                Description1 = value.Description1,
                Description2 = value.Description2,
                Description3 = value.Description3,
                Description4 = value.Description4,
                ImageUrl1 = value.ImageUrl1,
                ImageUrl2 = value.ImageUrl2,
                ImageUrl3 = value.ImageUrl3,


            };
        }
    }
}
