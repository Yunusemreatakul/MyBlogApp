using MediatR;
using MyPath.Application.Features.CQRSMediator.Command.ProfileCommands;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ProfileHandlers
{
    public class CreateProfileCommandHandle : IRequestHandler<CreateProfileCommand>
    {
        private readonly IRepository<Profile> _Repository;

        public CreateProfileCommandHandle(IRepository<Profile> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateProfileCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new Profile
            {
               UserId = request.UserId,
               CareerName = request.CareerName,
               CvUrl = request.CvUrl,
               DateOfBirth = request.DateOfBirth,
               FaceBookUrl = request.FaceBookUrl,
               GithubUrl = request.GithubUrl,
               ImageURL = request.ImageURL,
               InstagramUrl = request.InstagramUrl,
               LinkedinUrl = request.LinkedinUrl,
               PhoneNumber = request.PhoneNumber,
               ShortAddress = request.ShortAddress,
               VisibleFields = request.VisibleFields,
               FullName =request.FullName,
               Email = request.Email,
               XUrl = request.XUrl,
               


            });
        }
    }
}
