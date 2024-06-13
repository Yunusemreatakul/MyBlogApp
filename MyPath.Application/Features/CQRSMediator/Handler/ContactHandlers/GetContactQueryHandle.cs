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
    public class GetContactQueryHandle : IRequestHandler<GetContactQuery, List<GetContactQueryResult>>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandle(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetContactQueryResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactQueryResult
            {
                ContactId = x.ContactId,
                Email = x.Email,    
                FullName = x.FullName,
                Message = x.Message,
                SendUserId = x.SendUserId,
                UserId=x.UserId,
            }).ToList();
        }
    }
}
