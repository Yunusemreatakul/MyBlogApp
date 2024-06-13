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
    public class CreatePortfolioDetailCommandHandle : IRequestHandler<CreatePortfolioDetailCommand>
    {
        private readonly IRepository<PortfolioDetail> _Repository;

        public CreatePortfolioDetailCommandHandle(IRepository<PortfolioDetail> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreatePortfolioDetailCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new PortfolioDetail
            {
                
                    Title = request.Title,
                    PortfolioId = request.PortfolioId,
                    Text = request.Text,
                    TitleDesc = request.TitleDesc,
                    TitleImageUrl = request.TitleImageUrl,
                    DateReceived = request.DateReceived,
                    

            });
        }
    }
}
