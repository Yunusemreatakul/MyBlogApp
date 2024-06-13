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
    public class GetProfileQueryHandle : IRequestHandler<GetProfileQuery, List<GetProfileQueryResult>>
    {
        private readonly IRepository<Profile> _repository;

        public GetProfileQueryHandle(IRepository<Profile> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetProfileQueryResult>> Handle(GetProfileQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProfileQueryResult
            {
                CareerName = x.CareerName,
                CvUrl = x.CvUrl,
                DateOfBirth = x.DateOfBirth,
                FaceBookUrl = x.FaceBookUrl,
                GithubUrl = x.GithubUrl,
                ImageURL    = x.ImageURL,
                InstagramUrl = x.InstagramUrl,
                LinkedinUrl = x.LinkedinUrl,
                PhoneNumber = x.PhoneNumber,
                ProfileId = x.ProfileId,
                ShortAddress = x.ShortAddress,
                UserId = x.UserId,
                VisibleFields = x.VisibleFields,
                XUrl = x.XUrl,
            }).ToList();
        }
    }
}
