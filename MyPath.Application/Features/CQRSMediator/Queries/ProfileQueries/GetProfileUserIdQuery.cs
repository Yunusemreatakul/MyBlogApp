// GetProfileUserIdQuery.cs

using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.ProfileResult;
using System.Collections.Generic;

namespace MyPath.Application.Features.CQRSMediator.Queries.ProfileQueries
{
    public class GetProfileUserIdQuery : IRequest<GetProfileQueryResult>
    {
        public int UserId { get; set; }

        public GetProfileUserIdQuery(int userId)
        {
            UserId = userId;
        }
    }
}
