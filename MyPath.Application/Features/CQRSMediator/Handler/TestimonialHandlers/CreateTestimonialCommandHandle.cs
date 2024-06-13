using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.TestimonialCommands;
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
    public class CreateTestimonialCommandHandle:IRequestHandler<CreateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _Repository;

        public CreateTestimonialCommandHandle(IRepository<Testimonial> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new Testimonial
            {
                Comments = request.Comments,
                DateReceived = request.DateReceived,
                IsActive = request.IsActive,
                SendUserId = request.SendUserId,
                UserId = request.UserId
                

            });
        }
    }
}
