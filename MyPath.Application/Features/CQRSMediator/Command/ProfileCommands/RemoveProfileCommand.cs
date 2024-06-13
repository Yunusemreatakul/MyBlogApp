using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.ProfileCommands
{
    public class RemoveProfileCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveProfileCommand(int id)
        {
            Id = id;
        }
    }
}
