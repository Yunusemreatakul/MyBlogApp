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
    public class RemovePortfolioCommandHandle : IRequestHandler<RemovePortfolioCommand>
    {
        private readonly IRepository<Portfolio> _repository;

        public RemovePortfolioCommandHandle(IRepository<Portfolio> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemovePortfolioCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
