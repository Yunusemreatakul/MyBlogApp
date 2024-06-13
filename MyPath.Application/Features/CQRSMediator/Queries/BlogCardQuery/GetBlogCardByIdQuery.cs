using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.BlogCardResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.BlogCardQuery
{
    public class GetBlogCardByIdQuery: IRequest<GetBlogCardByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBlogCardByIdQuery(int id)
        {
            Id = id;
        }
    }
}
