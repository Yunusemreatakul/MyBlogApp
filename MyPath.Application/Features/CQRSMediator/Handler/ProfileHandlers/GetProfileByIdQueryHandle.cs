using MediatR;
using MyPath.Application.Features.CQRSMediator.Queries.ProfileQueries;
using MyPath.Application.Features.CQRSMediator.Result.ProfileResult;
using MyPath.Application.Interfaces;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Handler.ProfileHandlers
{
    public class GetProfileByIdQueryHandle : IRequestHandler<GetProfileByIdQuery, GetProfileByIdQueryResult>
    {
        private readonly IRepository<Profile> _repository;

        public GetProfileByIdQueryHandle(IRepository<Profile> repository)
        {
            _repository = repository;
        }
        public async Task<GetProfileByIdQueryResult> Handle(GetProfileByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetProfileByIdQueryResult
            {
                CareerName = value.CareerName,
                CvUrl = value.CvUrl,
                DateOfBirth = value.DateOfBirth,
                FaceBookUrl = value.FaceBookUrl,
                GithubUrl = value.GithubUrl,
                ImageURL = value.ImageURL,
                InstagramUrl = value.InstagramUrl,
                LinkedinUrl = value.LinkedinUrl,
                PhoneNumber = value.PhoneNumber,
                ProfileId = value.ProfileId,
                ShortAddress = value.ShortAddress,
                UserId = value.UserId,
                VisibleFields = value.VisibleFields,
                XUrl = value.XUrl,

            };
        }
    }
}
