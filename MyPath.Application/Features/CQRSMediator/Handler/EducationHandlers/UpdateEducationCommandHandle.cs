using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.EducationCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.EducationHandlers
{
    public class UpdateEducationCommandHandle : IRequestHandler<UpdateEducationCommand>
    {
        private readonly IRepository<Education> _reposistory;

        public UpdateEducationCommandHandle(IRepository<Education> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateEducationCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.EducationId);
            value.EducationId = request.EducationId;
            value.SchoolName = request.SchoolName;
            value.StartDate = request.StartDate;
            value.FinishDate = request.FinishDate;
            value.Description = request.Description;
            value.Address = request.Address;
            value.UserId = request.UserId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
