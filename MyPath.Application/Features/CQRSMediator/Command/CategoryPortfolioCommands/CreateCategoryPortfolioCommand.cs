using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.CategoryPortfolioCommands
{
    public class CreateCategoryPortfolioCommand:IRequest
    {
        public string CategoryName { get; set; }
        public int UserId { get; set; }
    }
}
