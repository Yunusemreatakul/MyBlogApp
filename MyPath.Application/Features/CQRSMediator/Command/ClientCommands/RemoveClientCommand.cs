using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.ClientCommands
{
    public class RemoveClientCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveClientCommand(int id)
        {
            Id = id;
        }
    }
}
