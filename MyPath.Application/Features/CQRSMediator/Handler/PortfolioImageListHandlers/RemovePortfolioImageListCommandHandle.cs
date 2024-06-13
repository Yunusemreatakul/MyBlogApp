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
    public class RemovePortfolioImageListCommandHandle : IRequestHandler<RemovePortfolioImageListCommand>
    {
        private readonly IRepository<PortfolioImageList> _repository;

        public RemovePortfolioImageListCommandHandle(IRepository<PortfolioImageList> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemovePortfolioImageListCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
