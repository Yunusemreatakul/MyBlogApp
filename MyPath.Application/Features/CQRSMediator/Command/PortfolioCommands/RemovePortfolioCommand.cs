﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.PortfolioCommands
{
    public class RemovePortfolioCommand:IRequest
    {
        public int Id { get; set; }

        public RemovePortfolioCommand(int id)
        {
            Id = id;
        }
    }
}