using AutoMapper;
using C2BMpesaAPI.Commands;
using C2BMpesaAPI.Logic;
using C2BMpesaAPI.Models;
using MediatR;
using MpesaApi.Controllers;
using MpesaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace C2BMpesaAPI.Handlers
{
    public class C2BSimulationHandler : IRequestHandler<C2BSimulationCommand, Object>
    {

        TokenRequest tokenRequest = new TokenRequest();


        AuthApiController apiController = new AuthApiController();
        ProcessC2BTransaction processB2C = new ProcessC2BTransaction();



        private readonly IMapper _mapper;

        public C2BSimulationHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<object> Handle(C2BSimulationCommand request, CancellationToken cancellationToken)
        {
            tokenRequest.ConsumerKey = request.b2CRequest.ConsumerKey;
            tokenRequest.consumersecret = request.b2CRequest.ConsumerSecret;
            var tokenResponse1 = (TokenResponse)apiController.GetAccessToken(tokenRequest);

            //token = tokenResponse.AccessToken;

            var b2CRequest1 = _mapper.Map<C2BRequest>(request.b2CRequest);

            var result = processB2C.ProcessTransaction1(b2CRequest1, tokenResponse1.AccessToken);

            return result;

        }
    }
}
