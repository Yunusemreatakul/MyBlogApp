using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.BlogCardCommands
{
    public class RemoveBlogCardCommad: IRequest
    {
        public int Id { get; set; }

        public RemoveBlogCardCommad(int id)
        {
            Id = id;
        }
    }
}
