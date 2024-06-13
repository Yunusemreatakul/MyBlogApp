using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class PortfolioDetail
    {
        [Key]
        public int PortfolioDetailId { get; set; }
        public string Title { get; set; }
        public string TitleDesc { get; set; }
        public string TitleImageUrl { get; set; }
        public DateOnly DateReceived { get; set; }
        public string Text { get; set; }

        public ICollection<PortfolioImageList> PortfolioImageLists { get; set; }

        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
