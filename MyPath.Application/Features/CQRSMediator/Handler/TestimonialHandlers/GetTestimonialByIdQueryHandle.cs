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
    public class GetTestimonialByIdQueryHandle : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandle(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult
            {
                UserId = value.UserId,
                Comments = value.Comments,
                DateReceived = value.DateReceived,
                IsActive = value.IsActive,
                SendUserId = value.SendUserId,
                TestimonialId = value.TestimonialId,

            };
        }
    }
}
