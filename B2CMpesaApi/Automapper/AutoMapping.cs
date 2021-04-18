
using AutoMapper;
using B2CMpesaApi.Models;
using B2CMpesaApi.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountBalanceApi.Automapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<B2CRequestDto, B2CRequest>(); // means you want to map from B2CRequestDto to B2CRequest

        }

    }
}
