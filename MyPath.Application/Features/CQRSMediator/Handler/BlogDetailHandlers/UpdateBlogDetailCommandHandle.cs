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
    public class UpdateBlogDetailCommandHandle : IRequestHandler<UpdateBlogDetailCommand>
    {
        private readonly IRepository<BlogDetail> _reposistory;

        public UpdateBlogDetailCommandHandle(IRepository<BlogDetail> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateBlogDetailCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.BlogDetailId);
            value.BlogDetailId = request.BlogDetailId;
            value.BlogTitle = request.BlogTitle;
            value.Description1 = request.Description1;
            value.Description2 = request.Description2;
            value.Description3 = request.Description3;
            value.Description4 = request.Description4;  
            value.ImageUrl1 = request.ImageUrl1;
            value.ImageUrl2 = request.ImageUrl2;
            value.ImageUrl3 = request.ImageUrl3;
            value.Contributed = request.Contributed;
            value.BlogCardId = request.BlogCardId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
