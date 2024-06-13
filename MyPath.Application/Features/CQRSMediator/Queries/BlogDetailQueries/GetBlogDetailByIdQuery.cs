using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.BlogDetailResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.BlogDetailQueries
{
    public class GetBlogDetailByIdQuery:IRequest<GetBlogDetailByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBlogDetailByIdQuery(int id)
        {
            Id = id;
        }
    }
}
