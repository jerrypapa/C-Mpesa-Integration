using MediatR;
using MpesaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthMpesaApi.Commands
{
    public class GetTokenCommand:IRequest<Object>
    {
        public TokenRequest tokenRequest { get; set; }
    }
}
