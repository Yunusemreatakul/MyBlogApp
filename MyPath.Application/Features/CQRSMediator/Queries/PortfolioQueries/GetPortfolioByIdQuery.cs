﻿using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.PortfolioResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.PortfolioQueries
{
    public class GetPortfolioByIdQuery:IRequest<GetPortfolioByIdQueryResult>
    {
        public int Id { get; set; }

        public GetPortfolioByIdQuery(int id)
        {
            Id = id;
        }
    }
}