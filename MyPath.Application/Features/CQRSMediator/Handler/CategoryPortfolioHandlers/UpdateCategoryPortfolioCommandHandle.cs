using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.CategoryPortfolioCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.CategoryPortfolioHandlers
{
    public class UpdateCategoryPortfolioCommandHandle : IRequestHandler<UpdateCategoryPortfolioCommand>
    {
        private readonly IRepository<CategoryPortfolio> _reposistory;

        public UpdateCategoryPortfolioCommandHandle(IRepository<CategoryPortfolio> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateCategoryPortfolioCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.CategoryPortfolioId);
            value.CategoryPortfolioId = request.CategoryPortfolioId;
            value.CategoryName = request.CategoryName;
            value.UserId = request.UserId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
