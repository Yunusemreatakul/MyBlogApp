using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.TestimonialCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandle : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _reposistory;

        public UpdateTestimonialCommandHandle(IRepository<Testimonial> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.TestimonialId);
            value.Comments = request.Comments;
            value.TestimonialId = request.TestimonialId;
            value.UserId = request.UserId;
            value.SendUserId = request.SendUserId;
            value.IsActive = request.IsActive;
            value.DateReceived = request.DateReceived;
            await _reposistory.UpdateAsync(value);
        }
    }
}
