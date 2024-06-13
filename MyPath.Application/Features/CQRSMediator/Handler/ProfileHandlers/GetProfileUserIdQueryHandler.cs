using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.ProfileQueries;
using MyPath.Application.Features.CQRSMediator.Result.ProfileResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ProfileHandlers
{
    public class GetProfileUserIdQueryHandler : IRequestHandler<GetProfileUserIdQuery, GetProfileQueryResult>
    {
        private readonly IRepository<Profile> _repository;

        public GetProfileUserIdQueryHandler(IRepository<Profile> repository)
        {
            _repository = repository;
        }

        public async Task<GetProfileQueryResult> Handle(GetProfileUserIdQuery request, CancellationToken cancellationToken)
        {
            var profiles = await _repository.GetAllAsync();
            var profile = profiles.FirstOrDefault(x => x.UserId == request.UserId);

            if (profile == null)
            {
                return null; // veya gerekli bir işlem yapılabilir
            }

            return new GetProfileQueryResult
            {
                CareerName = profile.CareerName,
                CvUrl = profile.CvUrl,
                DateOfBirth = profile.DateOfBirth,
                FaceBookUrl = profile.FaceBookUrl,
                GithubUrl = profile.GithubUrl,
                ImageURL = profile.ImageURL,
                InstagramUrl = profile.InstagramUrl,
                LinkedinUrl = profile.LinkedinUrl,
                PhoneNumber = profile.PhoneNumber,
                ProfileId = profile.ProfileId,
                ShortAddress = profile.ShortAddress,
                UserId = profile.UserId,
                VisibleFields = profile.VisibleFields,
                XUrl = profile.XUrl,
                FullName = profile.FullName,
                Email = profile.Email,
            };
        }
    }
}
