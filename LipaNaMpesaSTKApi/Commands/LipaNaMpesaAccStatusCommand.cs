using LipaNaMpesaSTKApi.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Commands
{
    public class LipaNaMpesaAccStatusCommand :IRequest<Object>
    {
        public LipaNaMpesaStatusRequestDto b2CRequest { get; set; }
    }
}
