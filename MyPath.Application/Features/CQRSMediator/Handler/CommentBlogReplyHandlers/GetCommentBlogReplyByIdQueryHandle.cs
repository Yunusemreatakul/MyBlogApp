using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.CommentBlogReplyQueries;
using MyPath.Application.Features.CQRSMediator.Result.CommentBlogReplyResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.CommentBlogReplyHandlers
{
    public class GetCommentBlogReplyByIdQueryHandle : IRequestHandler<GetCommentBlogReplyByIdQuery, GetCommentBlogReplyByIdQueryResult>
    {
        private readonly IRepository<CommentBlogReply> _repository;

        public GetCommentBlogReplyByIdQueryHandle(IRepository<CommentBlogReply> repository)
        {
            _repository = repository;
        }
        public async Task<GetCommentBlogReplyByIdQueryResult> Handle(GetCommentBlogReplyByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetCommentBlogReplyByIdQueryResult
            {
                CommentBId = value.CommentBId,
                CommentBlogReplyId = value.CommentBlogReplyId,
                Message = value.Message,
                SendUserId = value.SendUserId,
            };
        }
    }
}
