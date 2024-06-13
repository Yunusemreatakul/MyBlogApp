using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.BlogDetailCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.BlogDetailHandlers
{
    public class CreateBlogDetailCommandHandle : IRequestHandler<CreateBlogDetailCommand>
    {
        private readonly IRepository<BlogDetail> _Repository;

        public CreateBlogDetailCommandHandle(IRepository<BlogDetail> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateBlogDetailCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new BlogDetail
            {
               BlogCardId = request.BlogCardId,
               BlogTitle = request.BlogTitle,
               Contributed=request.Contributed,
               Description1 = request.Description1,
               Description2 = request.Description2,
               Description3 = request.Description3,
               Description4 = request.Description4,
               ImageUrl1 = request.ImageUrl1,
               ImageUrl2 = request.ImageUrl2,
               ImageUrl3 = request.ImageUrl3,

            });
        }
    }
}
