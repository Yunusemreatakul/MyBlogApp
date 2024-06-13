using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.EducationCommands
{
    public class RemoveEducationCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveEducationCommand(int id)
        {
            Id = id;
        }
    }
}
