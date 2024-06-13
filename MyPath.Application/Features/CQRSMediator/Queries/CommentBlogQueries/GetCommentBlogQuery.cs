using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.CommentBlogResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.CommentBlogQueries
{
    public class GetCommentBlogQuery:IRequest<List<GetCommentBlogQueryResult>>
    {
    }
}
