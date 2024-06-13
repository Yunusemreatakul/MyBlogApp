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
    public class CreateCategoryPortfolioCommandHandle : IRequestHandler<CreateCategoryPortfolioCommand>
    {
        private readonly IRepository<CategoryPortfolio> _Repository;

        public CreateCategoryPortfolioCommandHandle(IRepository<CategoryPortfolio> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateCategoryPortfolioCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new CategoryPortfolio
            {
                UserId = request.UserId,
                CategoryName = request.CategoryName,
                

            });
        }
    }
}
