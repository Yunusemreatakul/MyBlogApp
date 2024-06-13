using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.CategoryPortfolioCommands
{
    public class RemoveCategoryPortfolioCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveCategoryPortfolioCommand(int id)
        {
            Id = id;
        }
    }
}
