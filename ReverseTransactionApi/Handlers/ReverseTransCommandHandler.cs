using AutoMapper;
using MediatR;
using MpesaApi.Controllers;
using MpesaApi.Models;
using ReverseTransactionApi.Commands;
using ReverseTransactionApi.Logic;
using ReverseTransactionApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReverseTransactionApi.Handlers
{
    public class ReverseTransCommandHandler : IRequestHandler<ReverseTransCommand, Object>
    {

        TokenRequest tokenRequest = new TokenRequest();

        ReverseTransaction processB2C = new ReverseTransaction();
        AuthApiController apiController = new AuthApiController();


        private readonly IMapper _mapper;

        public ReverseTransCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<object> Handle(ReverseTransCommand request, CancellationToken cancellationToken)
        {
            tokenRequest.ConsumerKey = request.b2CRequest.ConsumerKey;
            tokenRequest.consumersecret = request.b2CRequest.ConsumerSecret;
            var tokenResponse1 = (TokenResponse)apiController.GetAccessToken(tokenRequest);

            //token = tokenResponse.AccessToken;

            var b2CRequest1 = _mapper.Map<ReverseTransactionRequest>(request.b2CRequest);

            var result = processB2C.ProcessTransaction1(b2CRequest1, tokenResponse1.AccessToken);
            return result;
        }
    }
}
