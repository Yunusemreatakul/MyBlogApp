using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.AboutCommands
{
    public class CreateAboutCommand : IRequest
    {
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}
