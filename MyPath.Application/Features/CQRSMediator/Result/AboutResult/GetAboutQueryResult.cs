using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Result.AboutResult
{
    public class GetAboutQueryResult
    {
        public int AboutId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}
