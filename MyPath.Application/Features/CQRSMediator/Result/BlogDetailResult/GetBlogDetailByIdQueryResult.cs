using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.BlogDetailResult
{
    public class GetBlogDetailByIdQueryResult:IRequest
    {
        public int BlogDetailId { get; set; }
        public string BlogTitle { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string Contributed { get; set; }
        public int BlogCardId { get; set; }
    }
}
