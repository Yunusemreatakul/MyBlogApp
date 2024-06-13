using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.AppUserResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.AppUserQueries
{
    public class GetCheckAppUserQuery:IRequest<GetCheckAppUserResult>
    {

        public string Email { get; set; }
        public string Password { get; set; }

    }
}
