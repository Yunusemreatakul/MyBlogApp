using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.RoleCommands
{
    public class UpdateRoleCommand:IRequest
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
