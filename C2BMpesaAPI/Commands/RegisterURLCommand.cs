using C2BMpesaAPI.Models;
using C2BMpesaAPI.Models.DTOS;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C2BMpesaAPI.Commands
{
    public class RegisterURLCommand :IRequest <Object>
    {
        public CustomerToBusinessRegisterUrlDTO b2CRequest { get; set; }
    }
}
