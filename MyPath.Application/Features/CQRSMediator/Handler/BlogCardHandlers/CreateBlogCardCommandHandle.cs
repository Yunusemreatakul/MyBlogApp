using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.BlogCardCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.BlogCardHandlers
{
    public class CreateBlogCardCommandHandle : IRequestHandler<CreateBlogCardCommand>
    {
        private readonly IRepository<BlogCard> _Repository;

        public CreateBlogCardCommandHandle(IRepository<BlogCard> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateBlogCardCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new BlogCard
            {
                BlogDetailId = request.BlogDetailId,
                BlogTitle = request.BlogTitle,
                CategoryBlog = request.CategoryBlog,
                DateReceived = request.DateReceived,
                ImageUrl = request.ImageUrl,
                ShortDescription = request.ShortDescription,
                UserId = request.UserId,
            });
        }
    }
}
