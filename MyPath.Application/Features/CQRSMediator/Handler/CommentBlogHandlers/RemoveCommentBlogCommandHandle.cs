using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.CommentBlogCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.CommentBlogHandlers
{
    public class RemoveCommentBlogCommandHandle : IRequestHandler<RemoveCommentBlogCommand>
    {
        private readonly IRepository<CommentBlog> _repository;

        public RemoveCommentBlogCommandHandle(IRepository<CommentBlog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCommentBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
