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
    public class CreateCommentBlogReplyCommandHandle : IRequestHandler<CreateCommentBlogReplyCommand>
    {
        private readonly IRepository<CommentBlogReply> _Repository;

        public CreateCommentBlogReplyCommandHandle(IRepository<CommentBlogReply> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateCommentBlogReplyCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new CommentBlogReply
            {
                SendUserId = request.SendUserId,
                Message = request.Message,
                CommentBId = request.CommentBId,
                

            });
        }
    }
}
