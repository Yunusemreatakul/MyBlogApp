using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.CommentBlogCommands
{
    public class CreateCommentBlogCommand:IRequest
    {
        public int SendUserId { get; set; }
        public string Comments { get; set; }
        public int LikeCount { get; set; }
        public DateTime DateReceived { get; set; }
        public int BlogDetailId { get; set; }
    }
}
