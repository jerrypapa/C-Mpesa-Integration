using B2CMpesaApi.Models;
using B2CMpesaApi.Models.DTOS;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2CMpesaApi.Commands
{
    public class B2CCommand:IRequest<object>
    {
       public B2CRequestDto b2CRequest { get; set; }
    }
}
