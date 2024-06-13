using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public  class PortfolioImageList
    {
        [Key]
        public int PortfolioImageListId { get; set; }
        public string ImageUrl { get; set; }
        public PortfolioDetail PortfolioDetail { get; set; }
        public int PortfolioDetailId { get; set; }

    }
}
