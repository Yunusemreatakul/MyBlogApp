using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public CategoryPortfolio CategoryPortfolio { get; set; }
        public int CategoryPortfolioId { get; set; }

        public PortfolioDetail PortfolioDetail { get; set; }
        public int PortfolioDetailId { get; set; }

    }
}
