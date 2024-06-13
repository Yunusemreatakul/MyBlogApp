using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.CategoryPortfolioResult
{
    public class GetCategoryPortfolioByIdQueryResult:IRequest
    {
        public int CategoryPortfolioId { get; set; }
        public string CategoryName { get; set; }
        public int UserId { get; set; }
    }
}
