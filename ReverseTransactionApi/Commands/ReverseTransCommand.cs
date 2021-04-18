using MediatR;
using ReverseTransactionApi.Models;
using ReverseTransactionApi.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseTransactionApi.Commands
{
    public class ReverseTransCommand: IRequest<Object>
    {
       public ReverseTransRequestDto b2CRequest { get; set; }
    }
}
