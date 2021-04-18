using AccountBalanceApi.Models;
using AccountBalanceApi.Models.DTOS;
using AutoMapper;

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
            CreateMap<AccountBalanceDto, AccountBalance>(); // means you want to map from AccountBalanceDto to AccountBalance

        }

    }
}
