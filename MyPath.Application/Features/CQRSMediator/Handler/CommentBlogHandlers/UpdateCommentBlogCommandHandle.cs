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
    public class UpdateCommentBlogCommandHandle : IRequestHandler<UpdateCommentBlogCommand>
    {
        private readonly IRepository<CommentBlog> _reposistory;

        public UpdateCommentBlogCommandHandle(IRepository<CommentBlog> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateCommentBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.CommendBlogId);
            value.CommendBlogId = request.CommendBlogId;
            value.SendUserId = request.SendUserId;
            value.Comments = request.Comments;
            value.LikeCount = request.LikeCount;
            value.DateReceived = request.DateReceived;
            value.BlogDetailId= request.BlogDetailId;
            
            await _reposistory.UpdateAsync(value);
        }
    }
}
