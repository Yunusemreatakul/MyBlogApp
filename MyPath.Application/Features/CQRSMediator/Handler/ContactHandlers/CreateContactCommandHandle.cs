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
    public class CreateContactCommandHandle : IRequestHandler<CreateContactCommand>
    {
        private readonly IRepository<Contact> _Repository;

        public CreateContactCommandHandle(IRepository<Contact> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new Contact
            {
               UserId = request.UserId,
               Email = request.Email,
               FullName = request.FullName,
               Message = request.Message,
               SendUserId = request.SendUserId,
               

            });
        }
    }
}
