using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.CommentBlogReplyCommands
{
    public class CreateCommentBlogReplyCommand:IRequest
    {
        public string Message { get; set; }
        public int SendUserId { get; set; }
        public int CommentBId { get; set; }
    }
}
