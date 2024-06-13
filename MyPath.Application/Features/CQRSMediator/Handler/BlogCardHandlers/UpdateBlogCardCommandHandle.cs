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
    public class UpdateBlogCardCommandHandle : IRequestHandler<UpdateBlogCardCommand>
    {
        private readonly IRepository<BlogCard> _reposistory;

        public UpdateBlogCardCommandHandle(IRepository<BlogCard> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateBlogCardCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.BlogCardId);
            value.ShortDescription = request.ShortDescription;
            value.CategoryBlog = request.CategoryBlog;
            value.DateReceived = request.DateReceived;
            value.BlogCardId = request.BlogCardId;
            value.BlogDetailId = request.BlogDetailId;
            value.BlogTitle= request.BlogTitle;
            value.ImageUrl = request.ImageUrl;
            value.UserId= request.UserId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
