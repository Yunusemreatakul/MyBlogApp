﻿using MediatR;
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
    public class GetClientByIdQueryHandle : IRequestHandler<GetClientByIdQuery, GetClientByIdQueryResult>
    {
        private readonly IRepository<Client> _repository;

        public GetClientByIdQueryHandle(IRepository<Client> repository)
        {
            _repository = repository;
        }
        public async Task<GetClientByIdQueryResult> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetClientByIdQueryResult
            {
                ClientId = request.Id,
                CompanyName = value.CompanyName,
                IsActive = value.IsActive,
                LogoUrl = value.LogoUrl,
                UserId = value.UserId,
                WebSiteUrl = value.WebSiteUrl,
            };
        }
    }
}