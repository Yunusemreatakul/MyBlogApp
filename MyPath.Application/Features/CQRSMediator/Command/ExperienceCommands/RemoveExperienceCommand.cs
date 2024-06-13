using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.ExperienceCommands
{
    public class RemoveExperienceCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveExperienceCommand(int id)
        {
            Id = id;
        }
    }
}
