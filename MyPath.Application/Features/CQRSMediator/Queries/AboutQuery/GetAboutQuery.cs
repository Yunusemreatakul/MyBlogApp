﻿using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.AboutResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.AboutQuery
{
    public class GetAboutQuery: IRequest<List<GetAboutQueryResult>>
    {
    }
}