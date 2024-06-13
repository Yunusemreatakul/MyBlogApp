using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.TestimonialResult
{
    public class GetTestimonialQueryResult: IRequest
    {
        public int TestimonialId { get; set; }
        public int SendUserId { get; set; }
        public string Comments { get; set; }
        public DateOnly DateReceived { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}
