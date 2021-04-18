using AccountBalance.Logic;
using AccountBalance.Models;
using AutoMapper;
using MediatR;
using MpesaApi.Controllers;
using MpesaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TransactionStatusApi.Commands;

namespace TransactionStatusApi.Handlers
{
    public class TransStatusCommandHandler : IRequestHandler<TransStatusCommand, Object>
    {
        TokenRequest tokenRequest = new TokenRequest();

        GetAccountBalance processB2C = new GetAccountBalance();
        AuthApiController apiController = new AuthApiController();

        private readonly IMapper _mapper;

        public TransStatusCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<object> Handle(TransStatusCommand request, CancellationToken cancellationToken)
        {
            tokenRequest.ConsumerKey = request.b2CRequest.ConsumerKey;
            tokenRequest.consumersecret =request.b2CRequest.ConsumerSecret;
            var tokenResponse1 = (TokenResponse)apiController.GetAccessToken(tokenRequest);

            //token = tokenResponse.AccessToken;

            var b2CRequest1 = _mapper.Map<AccountBalanceDto>(request.b2CRequest);

            var result = processB2C.ProcessTransaction1(b2CRequest1, tokenResponse1.AccessToken);
            return result;
        }
    }
}
