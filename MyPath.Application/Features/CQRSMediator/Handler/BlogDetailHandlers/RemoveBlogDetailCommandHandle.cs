using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.BlogDetailCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.BlogDetailHandlers
{
    public class RemoveBlogDetailCommandHandle : IRequestHandler<RemoveBlogDetailCommands>
    {
        private readonly IRepository<BlogDetail> _repository;

        public RemoveBlogDetailCommandHandle(IRepository<BlogDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBlogDetailCommands request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
