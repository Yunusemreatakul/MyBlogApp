using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.ClientQueries;
using MyPath.Application.Features.CQRSMediator.Result.ClientResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ClientHandlers
{
    public class GetClientQueryHandle : IRequestHandler<GetClientQuery, List<GetClientQueryResult>>
    {
        private readonly IRepository<Client> _repository;

        public GetClientQueryHandle(IRepository<Client> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetClientQueryResult>> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetClientQueryResult
            { ClientId = x.ClientId,
            CompanyName = x.CompanyName,
            IsActive = x.IsActive,
            LogoUrl = x.LogoUrl,    
            UserId = x.UserId,
            WebSiteUrl=x.WebSiteUrl,
            }).ToList();
        }
    }
}
