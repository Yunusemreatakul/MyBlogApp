using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.EducationCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.EducationHandlers
{
    public class CreateEducationCommandHandle : IRequestHandler<CreateEducationCommand>
    {
        private readonly IRepository<Education> _Repository;

        public CreateEducationCommandHandle(IRepository<Education> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateEducationCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new Education
            {
                FinishDate= request.FinishDate,
                Description= request.Description,
                StartDate= request.StartDate,   
                UserId= request.UserId, 
                Address= request.Address,   
                SchoolName= request.SchoolName,
                

            });
        }
    }
}
