using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.EducationCommands
{
    public class CreateEducationCommand:IRequest
    {
        public string SchoolName { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly FinishDate { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
    }
}
