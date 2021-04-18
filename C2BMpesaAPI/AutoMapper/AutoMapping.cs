
using AutoMapper;
using C2BMpesaAPI.Models;
using C2BMpesaAPI.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C2BMpesaAPI.Automapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<C2BRequestDTO, C2BRequest>(); // means you want to map from AccountBalanceDto to AccountBalance
            CreateMap<CustomerToBusinessRegisterUrlDTO, CustomerToBusinessRegisterUrl>();
        }

    }
}
