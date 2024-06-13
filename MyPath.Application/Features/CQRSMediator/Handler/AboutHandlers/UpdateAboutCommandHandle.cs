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
    public class UpdateAboutCommandHandle : IRequestHandler<UpdateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandle(IRepository<About> repository)
        {
            _repository = repository;
        }

       
        public async Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.AboutId);
            value.AboutId = request.AboutId;
            value.Description = request.Description;
            value.IsActive = false;
            value.UserId = request.UserId;
            await _repository.UpdateAsync(value);
        }
    }
}
