using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.BlogCardQuery;
using MyPath.Application.Features.CQRSMediator.Result.BlogCardResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.BlogCardHandlers
{
    public class GetBlogCardByIdQueryHandle : IRequestHandler<GetBlogCardByIdQuery, GetBlogCardByIdQueryResult>
    {
        private readonly IRepository<BlogCard> _repository;

        public GetBlogCardByIdQueryHandle(IRepository<BlogCard> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogCardByIdQueryResult> Handle(GetBlogCardByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetBlogCardByIdQueryResult
            {
                BlogCardId = value.BlogCardId,
                ImageUrl = value.ImageUrl,
                BlogDetailId = value.BlogDetailId,
                BlogTitle = value.BlogTitle,
                CategoryBlog = value.CategoryBlog,
                DateReceived = value.DateReceived,
                ShortDescription = value.ShortDescription,
                UserId = value.UserId,
            };
        }
    }
}
