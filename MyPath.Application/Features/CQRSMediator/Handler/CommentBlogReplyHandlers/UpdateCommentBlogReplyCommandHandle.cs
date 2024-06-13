using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.CommentBlogReplyCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.CommentBlogReplyHandlers
{
    public class UpdateCommentBlogReplyCommandHandle : IRequestHandler<UpdateCommentBlogReplyCommand>
    {
        private readonly IRepository<CommentBlogReply> _reposistory;

        public UpdateCommentBlogReplyCommandHandle(IRepository<CommentBlogReply> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateCommentBlogReplyCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.CommentBlogReplyId);
           value.CommentBlogReplyId = request.CommentBlogReplyId;
            value.Message = request.Message;
            value.SendUserId = request.SendUserId;
            value.CommentBId = request.CommentBId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
