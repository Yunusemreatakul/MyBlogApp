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
    public class GetCommentBlogByIdQueryHandle : IRequestHandler<GetCommentBlogByIdQuery, GetCommentBlogByIdQueryResult>
    {
        private readonly IRepository<CommentBlog> _repository;

        public GetCommentBlogByIdQueryHandle(IRepository<CommentBlog> repository)
        {
            _repository = repository;
        }
        public async Task<GetCommentBlogByIdQueryResult> Handle(GetCommentBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetCommentBlogByIdQueryResult
            {
                BlogDetailId = value.BlogDetailId,
                CommendBlogId = value.CommendBlogId,
                Comments = value.Comments,
                DateReceived = value.DateReceived,
                LikeCount = value.LikeCount,
                SendUserId = value.SendUserId,
            };
        }
    }
}
