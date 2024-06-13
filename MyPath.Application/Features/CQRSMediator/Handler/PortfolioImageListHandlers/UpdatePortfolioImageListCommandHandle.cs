using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.PortfolioImageListCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.PortfolioImageListHandlers
{
    public class UpdatePortfolioImageListCommandHandle : IRequestHandler<UpdatePortfolioImageListCommand>
    {
        private readonly IRepository<PortfolioImageList> _reposistory;

        public UpdatePortfolioImageListCommandHandle(IRepository<PortfolioImageList> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdatePortfolioImageListCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.PortfolioImageListId);
           value.PortfolioDetailId = request.PortfolioDetailId;
            value.ImageUrl = request.ImageUrl;
            value.PortfolioImageListId = request.PortfolioImageListId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
