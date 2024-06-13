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
    public class GetCommentBlogReplyQueryHandle : IRequestHandler<GetCommentBlogReplyQuery, List<GetCommentBlogReplyQueryResult>>
    {
        private readonly IRepository<CommentBlogReply> _repository;

        public GetCommentBlogReplyQueryHandle(IRepository<CommentBlogReply> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCommentBlogReplyQueryResult>> Handle(GetCommentBlogReplyQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCommentBlogReplyQueryResult
            {
                CommentBId = x.CommentBId,
                CommentBlogReplyId = x.CommentBlogReplyId,
                Message = x.Message,
                SendUserId = x.SendUserId,
            }).ToList();
        }
    }
}
