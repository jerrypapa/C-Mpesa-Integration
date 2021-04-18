using AccountBalanceApi.Commands;
using AccountBalanceApi.Logic;
using AccountBalanceApi.Models;
using AutoMapper;
using MediatR;
using MpesaApi.Controllers;
using MpesaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AccountBalanceApi.Handlers
{
    public class AccountBalanceCommandHandler : IRequestHandler<AccountBalanceCommand, Object>
    {
        TokenRequest tokenRequest = new TokenRequest();

        GetAccountBal processB2C = new GetAccountBal();
        AuthApiController apiController = new AuthApiController();


        private readonly IMapper _mapper;

        public AccountBalanceCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<object> Handle(AccountBalanceCommand request, CancellationToken cancellationToken)
        {

            tokenRequest.ConsumerKey = request.b2CRequest.ConsumerKey;
            tokenRequest.consumersecret = request.b2CRequest.ConsumerSecret;
            var tokenResponse1 = (TokenResponse)apiController.GetAccessToken(tokenRequest);

            var b2CRequest1 = _mapper.Map<AccountBalance>(request.b2CRequest);           
            var result = processB2C.ProcessTransaction1(b2CRequest1, tokenResponse1.AccessToken);
            return result;
        }
    }
}
