using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.BlogDetailCommands
{
    public class RemoveBlogDetailCommands:IRequest
    {
        public int Id { get; set; }

        public RemoveBlogDetailCommands(int id)
        {
            Id = id;
        }
    }
}
