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
    public class UpdateProfileCommandHandle : IRequestHandler<UpdateProfileCommand>
    {
        private readonly IRepository<Profile> _reposistory;

        public UpdateProfileCommandHandle(IRepository<Profile> reposistory)
        {
            _reposistory = reposistory;
        }

        public async Task Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
        {
            var value = await _reposistory.GetByIdAsync(request.ProfileId);
           value.ProfileId = request.ProfileId;
            value.ImageURL = request.ImageURL;
            value.CareerName = request.CareerName;
            value.DateOfBirth = request.DateOfBirth;
            value.FaceBookUrl = request.FaceBookUrl;
            value.InstagramUrl = request.InstagramUrl;
            value.XUrl = request.XUrl;
            value.GithubUrl = request.GithubUrl;
            value.LinkedinUrl   = request.LinkedinUrl;
            value.PhoneNumber = request.PhoneNumber;
            value.ShortAddress = request.ShortAddress;
            value.CvUrl = request.CvUrl;
            value.UserId = request.UserId;
            await _reposistory.UpdateAsync(value);
        }
    }
}
