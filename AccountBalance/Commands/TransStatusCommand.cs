using AccountBalance.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionStatusApi.Models.Dtos;

namespace TransactionStatusApi.Commands
{
    public class TransStatusCommand :IRequest<Object>
    {
       public TransStatusDto b2CRequest { get; set; }
    }
}
