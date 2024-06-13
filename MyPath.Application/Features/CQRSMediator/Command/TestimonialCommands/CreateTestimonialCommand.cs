using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.TestimonialCommands
{
    public class CreateTestimonialCommand:IRequest
    {
        public int SendUserId { get; set; }
        public string Comments { get; set; }
        public DateOnly DateReceived { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}
