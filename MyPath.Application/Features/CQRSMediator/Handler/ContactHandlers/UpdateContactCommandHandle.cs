using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.ContactCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ContactHandlers
{
    public class UpdateContactCommandHandle : IRequestHandler<UpdateContactCommand>
    {
        private readonly IRepository<Contact> _reposistory;

        public UpdateContactCommandHandle(IRepository<Contact> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.ContactId);
            value.ContactId = request.ContactId;
            value.FullName = request.FullName;
            value.Email = request.Email;
            value.Message = request.Message;
            value.SendUserId    = request.SendUserId;
            value.UserId= request.UserId;
            
            await _reposistory.UpdateAsync(value);
        }
    }
}
