using AutoMapper;
using B2BMpesaApi.Models;
using B2BMpesaApi.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BMpesaApi.AutoMapper
{
    public class AutoMapping :Profile
    {
        public AutoMapping()
        {
            CreateMap<B2BRequestDto, B2BRequest>(); // means you want to map from B2CRequestDto to B2CRequest

        }
        
    }
}
