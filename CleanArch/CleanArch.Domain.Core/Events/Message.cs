﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {

        protected Message()
        {
            MessageType = GetType().Name;
        }
        public string MessageType { get; protected set; }


    }
}