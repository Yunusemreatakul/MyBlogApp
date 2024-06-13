using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.ProfileResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.ProfileQueries
{
    public class GetProfileByIdQuery:IRequest<GetProfileByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProfileByIdQuery(int id)
        {
            Id = id;
        }
    }
}
