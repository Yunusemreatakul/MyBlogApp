using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.CommentBlogReplyCommands
{
    public class UpdateCommentBlogReplyCommand:IRequest
    {
        public int CommentBlogReplyId { get; set; }
        public string Message { get; set; }
        public int SendUserId { get; set; }
        public int CommentBId { get; set; }
    }
}
