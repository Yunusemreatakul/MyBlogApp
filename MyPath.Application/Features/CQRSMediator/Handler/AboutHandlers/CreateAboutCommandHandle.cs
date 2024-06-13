using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.AboutCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.AboutHandlers
{
    public class CreateAboutCommandHandle : IRequestHandler<CreateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public CreateAboutCommandHandle(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new About
            {
                Description = request.Description,
                IsActive = request.IsActive,
                UserId = request.UserId,
            });
        }
    }
}
