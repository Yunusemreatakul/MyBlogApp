using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.CommentBlogCommands
{
    public class RemoveCommentBlogCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveCommentBlogCommand(int id)
        {
            Id = id;
        }
    }
}
