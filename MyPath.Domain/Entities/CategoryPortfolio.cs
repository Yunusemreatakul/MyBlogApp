using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class CategoryPortfolio
    {
        [Key]
        public int CategoryPortfolioId { get; set; }
        public string CategoryName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
