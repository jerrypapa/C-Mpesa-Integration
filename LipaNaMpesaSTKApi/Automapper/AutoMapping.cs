using AutoMapper;
using LipaNaMpesaSTKApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Automapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<LipaOnline, LipaNaMpesaOnlineDto>(); // means you want to map from LipaOnline to LipaNaMpesaOnlineDto
            CreateMap<LipaNaMpesaStatusRequestDto, LipaNaMpesaStatusRequest>();
        }

    }
}
