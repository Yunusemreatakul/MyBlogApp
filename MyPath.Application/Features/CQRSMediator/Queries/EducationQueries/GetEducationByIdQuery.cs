using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.EducationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.EducationQueries
{
    public class GetEducationByIdQuery:IRequest<GetEducationByIdQueryResult>
    {
        public int Id { get; set; }

        public GetEducationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
