using MediatR;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.PortfolioCommands
{
    public class UpdatePortfolioCommand:IRequest
    {
        public int PortfolioId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public int CategoryPortfolioId { get; set; }
        public int PortfolioDetailId { get; set; }
    }
}
