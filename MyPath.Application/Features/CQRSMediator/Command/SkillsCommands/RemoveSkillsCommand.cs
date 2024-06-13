using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.SkillsCommands
{
    public class RemoveSkillsCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveSkillsCommand(int id)
        {
            Id = id;
        }
    }
}
