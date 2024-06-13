using MediatR;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.PortfolioImageListResult
{
    public class GetPortfolioImageListQueryResult: IRequest
    {
        public int PortfolioImageListId { get; set; }
        public string ImageUrl { get; set; }
        public int PortfolioDetailId { get; set; }
    }
}
