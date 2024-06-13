using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.PortfolioImageListCommands
{
    public class RemovePortfolioImageListCommand:IRequest
    {
        public int Id { get; set; }

        public RemovePortfolioImageListCommand(int id)
        {
            Id = id;
        }
    }
}
