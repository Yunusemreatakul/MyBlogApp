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
    public class RemoveCommentBlogReplyCommandHandle : IRequestHandler<RemoveCommentBlogReplyCommand>
    {
        private readonly IRepository<CommentBlogReply> _repository;

        public RemoveCommentBlogReplyCommandHandle(IRepository<CommentBlogReply> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCommentBlogReplyCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
