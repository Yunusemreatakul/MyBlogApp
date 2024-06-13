using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.BlogCardCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.BlogCardHandlers
{
    public class RemoveBlogCardCommandHandle : IRequestHandler<RemoveBlogCardCommad>
    {
        private readonly IRepository<BlogCard> _repository;

        public RemoveBlogCardCommandHandle(IRepository<BlogCard> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBlogCardCommad request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
