using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.PortfolioDetailCommands
{
    public class RemovePortfolioDetailCommand:IRequest
    {
        public int Id { get; set; }

        public RemovePortfolioDetailCommand(int id)
        {
            Id = id;
        }
    }
}
