using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.CommentBlogReplyResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.CommentBlogReplyQueries
{
    public class GetCommentBlogReplyByIdQuery:IRequest<GetCommentBlogReplyByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCommentBlogReplyByIdQuery(int id)
        {
            Id = id;
        }
    }
}
