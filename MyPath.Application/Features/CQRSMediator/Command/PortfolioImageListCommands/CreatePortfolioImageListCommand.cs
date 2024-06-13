using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.PortfolioImageListCommands
{
    public class CreatePortfolioImageListCommand:IRequest
    {
        public string ImageUrl { get; set; }
        public int PortfolioDetailId { get; set; }
    }
}
