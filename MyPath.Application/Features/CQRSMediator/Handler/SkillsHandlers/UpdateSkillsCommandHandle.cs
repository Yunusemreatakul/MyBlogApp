using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.SkillsCommands;
using MyPath.Application.Features.CQRSMediator.Command.UserCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.SkillsHandlers
{
    public class UpdateSkillsCommandHandle : IRequestHandler<UpdateSkillsCommand>
    {
        private readonly IRepository<Skils> _reposistory;

        public UpdateSkillsCommandHandle(IRepository<Skils> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateSkillsCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.SkilsId);
            value.SkilsId = request.SkilsId;
            value.IconUrl = request.IconUrl;
            value.SkilName = request.SkilName;
            value.Description = request.Description;
            value.Rate = request.Rate;
            value.CreatingIsActive = request.CreatingIsActive;
            value.SkilIsActive = request.SkilIsActive;
            value.LongDescription = request.LongDescription;
            value.UserId = request.UserId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
