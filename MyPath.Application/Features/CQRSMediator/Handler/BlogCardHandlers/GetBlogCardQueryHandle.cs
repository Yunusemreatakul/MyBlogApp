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
    public class GetBlogCardQueryHandle : IRequestHandler<GetBlogCardQuery, List<GetBlogCardQueryResult>>
    {
        private readonly IRepository<BlogCard> _repository;

        public GetBlogCardQueryHandle(IRepository<BlogCard> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogCardQueryResult>> Handle(GetBlogCardQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBlogCardQueryResult
            {
                BlogCardId=x.BlogCardId,
                BlogDetailId=x.BlogDetailId,
                BlogTitle = x.BlogTitle,
                CategoryBlog=x.CategoryBlog,
                DateReceived=x.DateReceived,
                ImageUrl=x.ImageUrl,
                ShortDescription=x.ShortDescription,
                UserId=x.UserId,
            }).ToList();
        }
    }
}
