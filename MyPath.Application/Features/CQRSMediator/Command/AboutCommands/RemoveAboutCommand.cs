﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Command.AboutCommands
{
    public class RemoveAboutCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveAboutCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
