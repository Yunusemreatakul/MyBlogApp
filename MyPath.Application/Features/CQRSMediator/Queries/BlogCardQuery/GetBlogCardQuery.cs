﻿using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.BlogCardResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.BlogCardQuery
{
    public class GetBlogCardQuery: IRequest<List<GetBlogCardQueryResult>>
    {
    }
}