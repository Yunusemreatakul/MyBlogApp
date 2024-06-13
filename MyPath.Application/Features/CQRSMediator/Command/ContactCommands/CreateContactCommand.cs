using MediatR;
using MyPath.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.ContactCommands
{
    public class CreateContactCommand:IRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int SendUserId { get; set; }
        public int UserId { get; set; }
    }
}
