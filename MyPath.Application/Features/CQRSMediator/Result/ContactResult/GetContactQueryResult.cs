using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.ContactResult
{
    public class GetContactQueryResult:IRequest
    {
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int SendUserId { get; set; }
        public int UserId { get; set; }
    }
}
