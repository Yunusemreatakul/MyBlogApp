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
    public class RemoveCategoryPortfolioCommandHandle : IRequestHandler<RemoveCategoryPortfolioCommand>
    {
        private readonly IRepository<CategoryPortfolio> _repository;

        public RemoveCategoryPortfolioCommandHandle(IRepository<CategoryPortfolio> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCategoryPortfolioCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
