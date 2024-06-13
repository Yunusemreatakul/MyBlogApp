using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.CommentBlogReplyCommands
{
    public class RemoveCommentBlogReplyCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveCommentBlogReplyCommand(int id)
        {
            Id = id;
        }
    }
}
