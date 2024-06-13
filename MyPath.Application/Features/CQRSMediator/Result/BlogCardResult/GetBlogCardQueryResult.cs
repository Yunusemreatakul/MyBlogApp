using MediatR;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.BlogCardResult
{
    public class GetBlogCardQueryResult:IRequest
    {
        public int BlogCardId { get; set; }
        public string ImageUrl { get; set; }
        public DateOnly DateReceived { get; set; }
        public string BlogTitle { get; set; }
        public string ShortDescription { get; set; }
        public string CategoryBlog { get; set; }
        public int UserId { get; set; }
        public int BlogDetailId { get; set; }
        
    }
}
