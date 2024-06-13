using MediatR;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.PortfolioDetailCommands
{
    public class UpdatePortfolioDetailCommand:IRequest
    {
        public int PortfolioDetailId { get; set; }
        public string Title { get; set; }
        public string TitleDesc { get; set; }
        public string TitleImageUrl { get; set; }
        public DateOnly DateReceived { get; set; }
        public string Text { get; set; }
        public int PortfolioId { get; set; }
    }
}
