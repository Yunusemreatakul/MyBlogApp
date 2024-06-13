using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.ProfileResult
{
    public class GetProfileByIdQueryResult: IRequest
    {
        public int ProfileId { get; set; }
        public string ImageURL { get; set; }
        public string CareerName { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public DateOnly DateOfBirth { get; set; }
        public string FaceBookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string XUrl { get; set; }
        public string GithubUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string ShortAddress { get; set; }
        public string CvUrl { get; set; }
        public List<string> VisibleFields { get; set; }
        public int UserId { get; set; }
    }
}
