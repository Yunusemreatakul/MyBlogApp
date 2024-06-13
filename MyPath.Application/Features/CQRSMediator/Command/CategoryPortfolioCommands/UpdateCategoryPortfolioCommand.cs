using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.CategoryPortfolioCommands
{
    public class UpdateCategoryPortfolioCommand:IRequest
    {
        public int CategoryPortfolioId { get; set; }
        public string CategoryName { get; set; }
        public int UserId { get; set; }
    }
}
