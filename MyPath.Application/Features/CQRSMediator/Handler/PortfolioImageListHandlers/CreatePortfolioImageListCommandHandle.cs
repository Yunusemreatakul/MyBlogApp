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
    public class CreatePortfolioImageListCommandHandle : IRequestHandler<CreatePortfolioImageListCommand>
    {
        private readonly IRepository<PortfolioImageList> _Repository;

        public CreatePortfolioImageListCommandHandle(IRepository<PortfolioImageList> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreatePortfolioImageListCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new PortfolioImageList
            {
                
                ImageUrl = request.ImageUrl,
                PortfolioDetailId = request.PortfolioDetailId,
                

            });
        }
    }
}
