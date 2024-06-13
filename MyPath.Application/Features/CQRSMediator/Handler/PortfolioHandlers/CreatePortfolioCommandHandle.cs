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
    public class CreatePortfolioCommandHandle : IRequestHandler<CreatePortfolioCommand>
    {
        private readonly IRepository<Portfolio> _Repository;

        public CreatePortfolioCommandHandle(IRepository<Portfolio> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreatePortfolioCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new Portfolio
            {

               PortfolioDetailId = request.PortfolioDetailId,
               PortfolioId = request.PortfolioId,
               ImageUrl = request.ImageUrl,
               CategoryPortfolioId = request.CategoryPortfolioId,
               Title = request.Title,
               UserId = request.UserId,
               


            });
        }
    }
}
