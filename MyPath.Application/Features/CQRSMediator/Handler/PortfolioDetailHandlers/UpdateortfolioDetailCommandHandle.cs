using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.PortfolioDetailCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.PortfolioDetailHandlers
{
    public class UpdatePortfolioDetailCommandHandle : IRequestHandler<UpdatePortfolioDetailCommand>
    {
        private readonly IRepository<PortfolioDetail> _reposistory;

        public UpdatePortfolioDetailCommandHandle(IRepository<PortfolioDetail> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdatePortfolioDetailCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.PortfolioDetailId);
           value.PortfolioDetailId = request.PortfolioDetailId;
            value.Title = request.Title;
            value.TitleDesc = request.TitleDesc;
            value.TitleImageUrl = request.TitleImageUrl;
            value.DateReceived = request.DateReceived;
            value.Text = request.Text;
            value.PortfolioId = request.PortfolioDetailId;

            await _reposistory.UpdateAsync(value);
        }
    }
}
