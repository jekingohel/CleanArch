﻿using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        
        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
            
        }

        public Task SenCommand<T>(T command) where T : Command
        {
            throw new NotImplementedException();
        }
    }
}