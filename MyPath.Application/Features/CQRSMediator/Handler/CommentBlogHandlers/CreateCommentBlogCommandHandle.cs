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
    public class CreateCommentBlogCommandHandle : IRequestHandler<CreateCommentBlogCommand>
    {
        private readonly IRepository<CommentBlog> _Repository;

        public CreateCommentBlogCommandHandle(IRepository<CommentBlog> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateCommentBlogCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new CommentBlog
            {
               SendUserId=request.SendUserId,
               BlogDetailId=request.BlogDetailId,   
               Comments=request.Comments,
               DateReceived=request.DateReceived,
               LikeCount=request.LikeCount,
               

            });
        }
    }
}
