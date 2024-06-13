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
    public class RemovePortfolioDetailCommandHandle : IRequestHandler<RemovePortfolioDetailCommand>
    {
        private readonly IRepository<PortfolioDetail> _repository;

        public RemovePortfolioDetailCommandHandle(IRepository<PortfolioDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemovePortfolioDetailCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
