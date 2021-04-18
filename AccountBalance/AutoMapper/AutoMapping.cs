
using AccountBalance.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionStatusApi.Models.Dtos;

namespace ReverseTransactionApi.Automapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<TransStatusDto, AccountBalanceDto>(); // means you want to map from LipaOnline to LipaNaMpesaOnlineDto
            
        }

    }
}
