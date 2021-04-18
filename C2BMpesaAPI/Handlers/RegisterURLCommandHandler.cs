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
    public class RegisterURLCommandHandler : IRequestHandler<RegisterURLCommand, Object>
    {
        TokenRequest tokenRequest = new TokenRequest();

        ProcessC2BTransaction processB2C = new ProcessC2BTransaction();
        AuthApiController apiController = new AuthApiController();

        private readonly IMapper _mapper;

        public RegisterURLCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<object> Handle(RegisterURLCommand request, CancellationToken cancellationToken)
        {
            tokenRequest.ConsumerKey = request.b2CRequest.ConsumerKey;
            tokenRequest.consumersecret = request.b2CRequest.ConsumerSecret;
            var tokenResponse1 = (TokenResponse)apiController.GetAccessToken(tokenRequest);

            var b2CRequest1 = _mapper.Map<CustomerToBusinessRegisterUrl>(request.b2CRequest);
            //token = tokenResponse.AccessToken;

            var result=processB2C.RegisterURLs1(b2CRequest1, tokenResponse1.AccessToken);
            return result;
        }
    }
}
