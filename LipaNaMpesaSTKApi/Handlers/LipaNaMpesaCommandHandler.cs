using AutoMapper;
using LipaNaMpesaSTKApi.Commands;
using LipaNaMpesaSTKApi.Logic;
using LipaNaMpesaSTKApi.Models;
using MediatR;
using MpesaApi.Controllers;
using MpesaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LipaNaMpesaSTKApi.Handlers
{
    public class LipaNaMpesaCommandHandler : IRequestHandler<LipaNaMpesaCommand, Object>
    {
        CalPassword calPassword = new CalPassword();
        TokenRequest tokenRequest = new TokenRequest();
        private readonly IMapper _mapper;

        public LipaNaMpesaCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }


        AuthApiController apiController = new AuthApiController();
        ProcessLipaNaMpesa processB2C = new ProcessLipaNaMpesa();
        public async Task<object> Handle(LipaNaMpesaCommand request, CancellationToken cancellationToken)
        {
            var b2CRequest1 = _mapper.Map<LipaNaMpesaOnlineDto>(request.b2CRequest);
            b2CRequest1.Password = calPassword.CalculatePassword(request.b2CRequest.BusinessShortCode, request.b2CRequest.Passkey, request.b2CRequest.Timestamp);

            tokenRequest.ConsumerKey = request.b2CRequest.ConsumerKey;
            tokenRequest.consumersecret = request.b2CRequest.ConsumerSecret;
            var tokenResponse1 = (TokenResponse)apiController.GetAccessToken(tokenRequest);

            //token = tokenResponse.AccessToken;

            var result = processB2C.ProcessTransaction1(b2CRequest1, tokenResponse1.AccessToken);
            return result;
        }
    }
}
