using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.TestimonialQueries;
using MyPath.Application.Features.CQRSMediator.Result.TestimonialResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.TestimonialHandlers
{
    public class GetTestimonialQueryHandle : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandle(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                Comments=x.Comments,
                DateReceived=x.DateReceived,
                IsActive=x.IsActive,
                SendUserId=x.SendUserId,
                TestimonialId=x.TestimonialId,
                UserId=x.UserId,
            }).ToList();
        }
    }
}
