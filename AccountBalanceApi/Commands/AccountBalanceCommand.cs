using AccountBalanceApi.Models;
using AccountBalanceApi.Models.DTOS;
using MediatR;
using MpesaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountBalanceApi.Commands
{
    public class AccountBalanceCommand :IRequest<Object>
    {
        
        public AccountBalanceDto b2CRequest { get; set; }
    }
}
