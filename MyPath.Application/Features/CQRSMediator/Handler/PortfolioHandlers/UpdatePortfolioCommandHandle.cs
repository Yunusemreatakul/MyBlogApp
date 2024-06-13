using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.PortfolioCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.PortfolioHandlers
{
    public class UpdatePortfolioCommandHandle : IRequestHandler<UpdatePortfolioCommand>
    {
        private readonly IRepository<Portfolio> _reposistory;

        public UpdatePortfolioCommandHandle(IRepository<Portfolio> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdatePortfolioCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.PortfolioId);
            value.PortfolioId = request.PortfolioId;
            value.ImageUrl = request.ImageUrl;
            value.Title = request.Title;
            value.UserId= request.UserId;
            value.CategoryPortfolioId = request.CategoryPortfolioId;
            value.PortfolioDetailId = request.PortfolioDetailId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
