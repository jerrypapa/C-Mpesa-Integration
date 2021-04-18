using B2BMpesaApi.Models.DTOS;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BMpesaApi.Commands
{
    public class B2bCommand : IRequest<Object>
    {
        public B2BRequestDto bRequestDto { get; set; }
    }
}
