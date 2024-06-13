using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.ClientResult
{
    public class GetClientQueryResult:IRequest
    {
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public string LogoUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}
