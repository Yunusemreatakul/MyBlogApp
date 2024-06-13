using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.CommentBlogQueries;
using MyPath.Application.Features.CQRSMediator.Result.CommentBlogResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.CommentBlogHandlers
{
    public class GetCommentBlogQueryHandle : IRequestHandler<GetCommentBlogQuery, List<GetCommentBlogQueryResult>>
    {
        private readonly IRepository<CommentBlog> _repository;

        public GetCommentBlogQueryHandle(IRepository<CommentBlog> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCommentBlogQueryResult>> Handle(GetCommentBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCommentBlogQueryResult
            {
                BlogDetailId    =x.BlogDetailId,
                CommendBlogId = x.CommendBlogId,
                Comments = x.Comments,
                DateReceived = x.DateReceived,
                LikeCount = x.LikeCount,
                SendUserId=x.SendUserId,
            }).ToList();
        }
    }
}
