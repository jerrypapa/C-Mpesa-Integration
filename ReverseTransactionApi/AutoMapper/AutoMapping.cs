using AutoMapper;

using ReverseTransactionApi.Models;
using ReverseTransactionApi.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseTransactionApi.Automapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<ReverseTransRequestDto, ReverseTransactionRequest>(); // means you want to map from LipaOnline to LipaNaMpesaOnlineDto
            
        }

    }
}
