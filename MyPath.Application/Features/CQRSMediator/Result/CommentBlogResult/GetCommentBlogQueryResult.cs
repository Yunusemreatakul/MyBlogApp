using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.CommentBlogResult
{
    public class GetCommentBlogQueryResult:IRequest
    {
        public int CommendBlogId { get; set; }
        public int SendUserId { get; set; }
        public string Comments { get; set; }
        public int LikeCount { get; set; }
        public DateTime DateReceived { get; set; }
        public int BlogDetailId { get; set; }
    }
}
