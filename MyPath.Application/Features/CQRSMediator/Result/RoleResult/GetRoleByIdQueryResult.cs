﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.RoleResult
{
    public class GetRoleByIdQueryResult: IRequest
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}