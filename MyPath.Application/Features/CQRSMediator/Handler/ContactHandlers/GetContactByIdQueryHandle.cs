using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.ContactQueries;
using MyPath.Application.Features.CQRSMediator.Result.ContactResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ContactHandlers
{
    public class GetContactByIdQueryHandle : IRequestHandler<GetContactByIdQuery, GetContactByIdQueryResult>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandle(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetContactByIdQueryResult
            {
                ContactId = value.ContactId,
                Email = value.Email,
                FullName = value.FullName,
                Message = value.Message,
                SendUserId = value.SendUserId,
                UserId = value.UserId,
            };
        }
    }
}
